import React from 'react';



const Message = (props) => (

    
    <div style={{ borderRadius: '5px', padding: '0 10px' }}>
        <p> <b> {props.user}: </b>{props.message}</p>
        <hr />
    </div>
);
export default Message;