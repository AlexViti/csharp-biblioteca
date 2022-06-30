using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBiblioteca
{
    internal class Rent
    {
        public User User { get; internal set; }
        public Document Document { get; internal set; }
        public DateOnly From { get; internal set; }
        public DateOnly? To { get; set; }

        public Rent(User user, Document document, DateOnly from)
        {
            User = user;
            Document = document;
            From = from;
        }
    }
}
