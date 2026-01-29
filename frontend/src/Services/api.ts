const API_URL = 'https://localhost:7295/api/users';


export const fetchUsers = async () => {
    const response = await fetch(API_URL);
    if (!response.ok) { throw new Error('Network response was not ok'); }
    return response.json();
}