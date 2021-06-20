import React, { useState, useEffect } from 'react'
import User from './User'

export default function UsersMenu(props) {

    const [allUsers, setAllUsers] = useState([])

    useEffect(() => {
        // setAllUsers(props.AllUsers);
        setAllUsers(
            [

                {
                    name: 'mhmd'
                },
                {
                    name: 'test'
                },
                {
                    name: 'tuwaiq'
                }
            ]
                )
    }, [])


    return (
        <div>
            <h4> Available Users </h4>

            <User allUsers={allUsers} />
        </div>
    )
}
