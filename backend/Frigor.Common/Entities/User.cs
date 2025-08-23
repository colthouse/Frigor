using Frigor.Common.Dtos;

namespace Frigor.Common.Entities;

public class User
{
    public User() {
    }

    public User(string name)
    {
        Name = name;
    }

    public Guid Uuid { get; set; }
    public string Name { get; set; } = null!;
    public int Habit { get; set; }
    public List<Guid> Responsibilities { get; set; } = [];
    
    public UserDto ToDto()
    {
        return new UserDto(Uuid, Name);
    }
}
