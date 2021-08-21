namespace Repository.Entity
{
    public class PersonEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public UserEntity User { get; set; }
    }
}
