import React, { useState } from "react";

const MessageInput = (props) => {
  const [message, setMessage] = useState("");

  const onSubmit = (e) => {
    e.preventDefault();
    const isMessageProvided = message && message !== "";
    if (isMessageProvided) {
      props.sendMessage(message);
    } else {
      alert("Please insert a message.");
    }
  };
  const onMessageUpdate = (e) => {
    setMessage(e.target.value);
  };
  return (
    <div class="input-group">
      <form onSubmit={onSubmit}>



            <input
              className="form-control d-inline"
              type="text"
              id="message"
              placeholder="Enter message"
              name="message"
              aria-describedby="button-send"
              value={message}
              onChange={onMessageUpdate}
              style={{ width: "450px" }}
            />
            <button class="btn btn-secondary float-right ml-3" id="button-send">
              Send
            </button>

        <br></br>
      </form>
    </div>
  );
};
export default MessageInput;
