import React, { useState, useEffect } from 'react'
import User from './User'

export default function UsersMenu(props) {
    const [allUsers, setAllUsers] = useState(props.users);
    
    return (
        <div>
            <h4> All Users </h4>
            <User onUserSelect={(selectedUser) => props.selectedUser(selectedUser)} allUsers={allUsers} />
        </div>
    )
}
