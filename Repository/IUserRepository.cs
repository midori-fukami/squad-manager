using Repository.Entity;

namespace Repository
{
    public interface IUserRepository
    {
        public void Add(UserEntity entity);

        public void Update(UserEntity entity);
    }
}
