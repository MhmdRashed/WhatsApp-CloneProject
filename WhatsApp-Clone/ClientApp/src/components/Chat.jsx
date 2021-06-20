import React, { useState, useEffect} from 'react';
import MessageList from './MessageList';
import MessageInput from './MessageInput';
import UsersMenu from './UsersMenu';

const Chat = () => {
    //const [ connection, setConnection ] = useState(null);
    //const [ chat, setChat ] = useState([]);

    //const sendMessage = async (user, message) => {
     //   const chatMessage = {
       //     user: user,
       //     message: message
       // };

    


    return (
        <div>

            <div className="row">
                <div className="col-9">
                <MessageList/> 
            {/* call sendMessage here */}
            <hr />
            <MessageInput/> 
            {/* send chat here */}

                </div>

                <div className="col-3">

                <UsersMenu />

                </div>

            </div>

      
        </div>
    );
};

export default Chat;