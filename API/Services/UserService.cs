using Common;

using Repository;
using Repository.Entity;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                PersonId = model.PersonId,
                Password = model.Password,
                Type = EnumType.ADMIN.ToString()
            };

            _userRepository.Add(entity);
        }
    }
}
