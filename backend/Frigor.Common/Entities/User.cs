using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class User
{
    public Guid Uuid { get; set; }
    public string Name { get; set; } = null!;

    public UserDto ToDto()
    {
        return new UserDto(){
            Uuid = Uuid,
            Name = Name
        };
    }
}
