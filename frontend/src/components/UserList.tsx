import type { User } from "../types";

interface Props {
    users: User[];
}


export const UserList = ({ users }: Props) => {
    if (users.length === 0) { 
        return <p>No users found.</p>;
    }

    return (
        <ul>
            {users.map((user) => (
                <li key={user.id}>
                    <strong>{user.name}</strong> - Age: {user.age} years old 
                </li>
            ))}
        </ul>
    )
}