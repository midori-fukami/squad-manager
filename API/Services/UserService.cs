using Common;

using Repository;
using Repository.Entity;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Password = model.Password,
                Type = EnumType.ADMIN.ToString()
            };

            _userRepository.Add(entity);
        }
    }
}
