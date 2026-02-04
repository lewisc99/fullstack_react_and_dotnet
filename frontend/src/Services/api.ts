import type { User } from "../types";

const API_URL = 'https://localhost:7295/api/users';


export const fetchUsers = async () => {
    const response = await fetch(API_URL);
    if (!response.ok) { throw new Error('Network response was not ok'); }
    return response.json();
}

export const createUser = async (user: User) : Promise<User> => { const response = 
    await fetch(API_URL, {
        method: 'POST',
        headers: { "Content-Type": "application/json" },   
        body: JSON.stringify(user),
    });

    if (!response.ok)
    {
        const erroData  = await response.json();
        throw new Error(erroData.message || 'Failed to create user');
    }

    return response.json();
}