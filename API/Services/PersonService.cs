using Common;

using Repository;
using Repository.Entity;

namespace API.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public int AddPerson(PersonModel model)
        {
            PersonEntity entity = new PersonEntity()
            {
                Name = model.Name,
                Email = model.Email,
                Type = model.Type
            };

            return _personRepository.Add(entity);
        }

        public void UpdatePerson(PersonModel model)
        {
            PersonEntity entity = new PersonEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Type = model.Type
            };

            _personRepository.Update(entity);
        }

        public PersonModel GetPerson(int id)
        {
            var entity = _personRepository.Get(id);
            return new PersonModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Type = entity.Type
            };
        }

        public void DeletePerson(int id)
        {
            _personRepository.Delete(id);
        }
    }
}
