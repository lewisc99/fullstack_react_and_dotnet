import { useEffect, useState } from 'react';
import './App.css'
import type { User } from './types';
import { fetchUsers } from './Services/api';
import { UserList } from './components/UserList';
import { UserForm } from './components/UserForm';

function App() {
  const [users, setUsers] = useState<User[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    loadUsers();
  }, []); 

  const loadUsers = async () => {
    try {
      setLoading(true);
      const data = await fetchUsers();
      setUsers(data);
      setError(null);
    } catch {
      setError("Could not load users.");
    } finally {
      setLoading(false);
    }
  }

  const handleAddUser = async (user: User): Promise<void> => {
    try {
      // const created = 
      setUsers((prev) => [...prev, user]);
      setError(null);
    } catch {
      alert('Error adding user.');
    }
  }

  return (
    <div style={{maxWidth: "600px", margin: "0 auto", padding: "2rem"}}>
      <h1>User Management</h1>
      
      <UserForm onAddUser={handleAddUser}  />
      <hr />

      {loading && <p>Loading users...</p>}
      {error && <p style={{color: "red"}}>{error}</p>}
      {!loading && !error && <UserList users={users} />}
    </div>
  )
}

export default App
