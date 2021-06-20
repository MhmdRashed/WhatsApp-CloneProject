import React, { useState, useEffect} from 'react';
import MessageList from './MessageList';
import MessageInput from './MessageInput';
import UsersMenu from './UsersMenu';
import { HubConnectionBuilder } from '@microsoft/signalr';
import authService from './api-authorization/AuthorizeService';

const Chat = () => {
    const [connection, setConnection] = useState(null);
    // [name,[rooms]]
    const [users, setUsers] = useState([]);
    // name, [rooms]
    const [targetUser, setTargetUser] = useState(null);
    // [content, sender, roomId]
    const [ messages, setMessages ] = useState([]);

    const loadUsers = (users) => {
        setUsers(users);
    }
    
    const loadChat = (chat) => {
        setMessages(chat)
    }

    // input.sender, input.content
    const sendMessage = (input) => {
        // send(input.content, input.sender.name, input.sender.roomId)
    }

    const receiveMessage = (message) => {
        setMessages([...messages, message]);
    }

    useEffect(() => {
        const newConnection = new HubConnectionBuilder()
        .withUrl("https://localhost:5001/hubs/chat")
        .withAutomaticReconnect().build();

        setConnection(newConnection);
    }, []);

    useEffect(() => {
        if(connection) {
            connection.start()
            .then(() => {
                console.log("Connected!");

                connection.on('ReceiveMessage', message => {
                    receiveMessage(message);
                });

                connection.on('ReceiveData', (users, chat) => {
                    // [name, roomName]
                    loadUsers(users);
                    // [message, sender]
                    loadChat(chat);
                });
            })
            .catch(err => console.log('Connection failed: ', err));
        }
    }, [connection]);

    return (
        <div>
            <div className="row">
                <div className="col-9">
                    <MessageList chat={messages}/> 
                    <hr />
                    <MessageInput sendMessage={sendMessage}/> 
                </div>

                <div className="col-3">
                    <UsersMenu users={users} onUserSelect={(selectedUser) => {setTargetUser(selectedUser)}}/>
                </div>
            </div>
        </div>
    );
};

export default Chat;