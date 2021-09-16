using Common;

namespace API.Services
{
    public interface IPersonService
    {
        public int AddPerson(PersonModel model);

        public void UpdatePerson(PersonModel model);
    }
}
