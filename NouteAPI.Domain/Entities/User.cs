using System;

namespace NouteAPI.Domain.Entities
{
    public class User
    {
        public User()
        {
            this.RegistrationDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}