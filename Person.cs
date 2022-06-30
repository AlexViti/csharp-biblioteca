using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBiblioteca
{
    internal abstract class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }


        protected Person(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }
    }

    internal class Author : Person
    {
        public Author(string surname, string name) : base(surname, name) { }

    }

    internal class User : Person
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public List<Rent> Rents { get; }

        public User(string surname, string name, string email, string password, long phone) : base(surname, name)
        {
            Email = email;
            Password = password;
            Phone = phone;
            Rents = new List<Rent>();
        }
    }

    internal class Admin : User
    {
        public Admin(string surname, string name, string email, string password, long phone)
            : base(surname, name, email, password, phone) { }
    }
   
}
