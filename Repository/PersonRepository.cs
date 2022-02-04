using Repository.Context;
using Repository.Entity;
using System.Linq;

namespace Repository
{
    public class PersonRepository : IPersonRepository
    {
        protected EFContext _dataContext;

        public PersonRepository(EFContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int Add(PersonEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();

            return entity.Id;
        }

        public void Update(PersonEntity entity)
        {
            _dataContext.Update(entity);
            _dataContext.SaveChanges();
        }

        public PersonEntity Get(int id)
        {
            return _dataContext.Persons.FirstOrDefault(o =>
                o.Id == id);
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            _dataContext.Persons.Remove(entity);
            _dataContext.SaveChanges();

        }
    }
}
