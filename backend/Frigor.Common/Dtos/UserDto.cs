namespace Frigor.Common.Dtos;


public class UserDto
{
    public Guid Id { get; set;  }
    public string Name { get; set; }

    public UserDto(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}