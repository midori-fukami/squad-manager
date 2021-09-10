using Repository.Context;
using Repository.Entity;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        protected EFContext _dataContext;

        public PersonRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(PersonEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
