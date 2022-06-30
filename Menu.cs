using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBiblioteca
{
    internal class Menu
    {
        protected string title;
        protected Menu[]? subMenus;
        
        public Menu(string title)
        {
            this.title = title;
        }
        
        public Menu(string title, Menu[] subMenus)
        {
            this.title = title;
            this.subMenus = subMenus;
        }

        public void Run()
        {
            Console.Clear();
            char input = ' ';
            do
            {
                Console.WriteLine(title);
                do
                {
                    input = Console.ReadKey().KeyChar;
                }
                while (input != '1');
                input = Console.ReadKey().KeyChar;
            }
            while (input != '4');
        } 
    }
}
