using DddMvc.AppServices.Interfaces.Services;
using DddMvc.Dal.Interfaces.Repository;

namespace DddMvc.AppServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        // private readonly ILogger<UserService> _logger;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}