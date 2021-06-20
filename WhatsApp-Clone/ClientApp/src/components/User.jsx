import React, { useState, useEffect } from 'react'

export default function User(props) {
    const displayUsers = props.allUsers.map((user, i) => {
        return(
            <input type="button" class="list-group-item list-group-item-action" key={i} onClick={() => props.onUserSelect(user)}>{user.name}</input>
        )
    })

    return (
        <div class="list-group">
            {displayUsers}
        </div>
    )
}
