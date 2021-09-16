using Common;

namespace API.Services
{
    public interface IUserService
    {
        public void AddUser(UserModel model);

        public void UpdateUser(UserModel model);
    }
}
