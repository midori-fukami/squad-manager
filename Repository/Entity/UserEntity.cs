using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Type { get; set; }

        public string ResetHash { get; set; }

        public string Password { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public PersonEntity Person { get; set; }
    }
}
