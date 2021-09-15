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
                Username = model.Username,
                Email = model.Email
            };

            return _personRepository.Add(entity);
        }
    }
}
