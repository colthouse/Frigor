namespace Frigor.Common.Dtos;


public class UserDto
{
    public Guid Uuid { get; set;  }
    public string Name { get; set; }

    public UserDto(Guid uuid, string name)
    {
        Uuid = uuid;
        Name = name;
    }
}
