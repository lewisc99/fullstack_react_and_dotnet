using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos;


public record CreateUserDto(
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, MinimumLength = 2)]
    string Name,

    [Required]
    [Range(0, 120, ErrorMessage = "Age must be between 0 and 120")]
    int Age);

public record UserDto(Guid Id, string Name, int Age);