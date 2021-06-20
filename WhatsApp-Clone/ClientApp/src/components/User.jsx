import React, { useState, useEffect } from 'react'

export default function User(props) {



    const displayUsers = props.allUsers.map((user, i) => {
        return(
            <a href="#" class="list-group-item list-group-item-action" key={i}>{user.name}</a>
        )
    })

    return (
            <div class="list-group">
            {displayUsers}
            </div>
        
    )
}
