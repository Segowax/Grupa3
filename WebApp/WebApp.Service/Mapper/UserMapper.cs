using WebApp.Domain.Entities;
using WebApp.Service.DTO;

namespace WebApp.Service.Mapper
{
    internal static class UserMapper
    {
        internal static User MapToUser(this UserDto userDto) =>
            new()
            {
                
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                PhoneNumber = userDto.PhoneNumber,
                Email = userDto.Email,
                Adress = userDto.Adress,
                Password = userDto.Password,
                CreatedDate = userDto.CreatedDate,
                Role = userDto.Role,
            };

        internal static UserDto MapToEntity(this User user) =>
            new()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber =user.PhoneNumber,
                Email = user.Email,
                Adress = user.Adress,
                Password = user.Password,
                CreatedDate = user.CreatedDate,
                Role = user.Role,
            };
    }
}
    
