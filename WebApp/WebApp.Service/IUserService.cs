using WebApp.Service.DTO;

namespace WebApp.Service
{
    public interface IUserService
    {
        Task AddUser(UserDto user);
        Task<UserDto> GetUser(int id);
    }
    
}
