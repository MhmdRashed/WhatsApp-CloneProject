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
        <div className="row">
          <div className="col-11">
            <input
              className="form-control"
              type="text"
              id="message"
              placeholder="Enter message"
              name="message"
              aria-describedby="button-send"
              value={message}
              onChange={onMessageUpdate}
              style={{ width: "450px" }}
            />
          </div>

          <div className="col-1">
            <button class="btn btn-outline-secondary" id="button-send">
              Send
            </button>
          </div>
        </div>

        <br></br>
      </form>
    </div>
  );
};
export default MessageInput;
