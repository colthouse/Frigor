using System.ComponentModel.DataAnnotations;
using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class User
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public int Habit { get; set; }

    public UserDto toDto()
    {
        return new UserDto(this.Id, this.Name);
    }
}