using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Entity
{
    public class UserEntity
    {
        public string Id { get; set; }       

        public string Type { get; set; }

        public string ResetHash { get; set; }

        public string Password { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public PersonEntity Person { get; set; }
    }
}
