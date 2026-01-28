using System.Diagnostics.CodeAnalysis;

namespace WebApi.Entities;

public class User
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Name { get; set; }
    public int Age { get; set; }

    [SetsRequiredMembers] // This tells the compiler the requirements are met here
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public User() { }
}
