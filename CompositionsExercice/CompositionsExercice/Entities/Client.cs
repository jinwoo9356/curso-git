using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionsExercice.Entities
{
    class Client
    {
        public String Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "\nName: "
                + Name
                + "\nBirth Date: "
                + BirthDate.ToString("dd/MM/yyyy")
                + "\nE-mail: "
                + Email;
        }
    }
}
