using Repository.Entity;

namespace Repository
{
    public interface IPersonRepository
    {
        public void Add(PersonEntity entity);
    }
}
