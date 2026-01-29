import { useState } from "react";
import type { User } from "../types";

interface Props {
    onAddUser: (user: User) => Promise<void>;
}

export const UserForm: React.FC<Props> = ({ onAddUser }) => {

    const [name, setName] = useState("");
    const [age, setAge] = useState<string>("");

    const handleSubmit = async (e: React.FormEvent) => {
        console.log("Submitting form", e);
    }

    return (
        <form onSubmit={handleSubmit} style={{marginBottom: "2rem", padding: "1rem", border: "1px solid #ccc"}}>
            <h2>Add New User</h2>
            <div style={{marginBottom: "10px"}}>
                <input type="text"
                placeholder="Name" 
                value={name}
                onChange={(e) => setName(e.target.value)}
                required />
            </div>
            <div style={{marginBottom: "10px"}}>
                <input type="number"
                placeholder="Age"
                value={age}
                onChange={(e) => setAge(e.target.value)}
                required
                min="0"
                max="120" />
            </div>
            <div>
                <button type="submit">Add User</button>
            </div>
            </form>
    )

}