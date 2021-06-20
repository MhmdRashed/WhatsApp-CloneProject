import React from 'react';
import Message from './Message';

const MessageList = (props) => {
    const chat = props.chat
    .map(m => <Message message={m.message} user={m.user}/>);

    return(
        <div className="row">
           <div className="pt-3" style={{backgroundColor: 'white', width: '750px', height: '350px', border: '1px solid lightgray', borderRadius: "15px"}}>
                {{chat}}
           </div>
        </div>
    )
};

export default MessageList;

