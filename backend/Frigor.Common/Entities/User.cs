using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class User
{
    public User(string name)
    {
        Name = name;
        
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public int Habit { get; set; }

    public UserDto toDto()
    {
        return new UserDto(Id, Name);
    }
}