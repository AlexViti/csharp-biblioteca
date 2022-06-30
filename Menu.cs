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
        protected Menu[] subMenus;
        
        public Menu(string title)
        {
            this.title = title;
            this.subMenus = new Menu[0];
        }
        
        public Menu(string title, Menu[] subMenus)
        {
            this.title = title;
            this.subMenus = subMenus;
        }

        public void Display()
        {
            char input = ' ';
            List<char> choices = new List<char>();
            for (int i = 0; i < subMenus.Length; i++)
            {
                choices.Add((char)(i + 49));
            }
            do
            {
                Console.WriteLine("\n{0}", title);
                Console.WriteLine();
                for (int i = 0; i < subMenus.Length; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, subMenus[i].title);
                }
                input = Console.ReadKey().KeyChar;
            } while (!choices.Contains(input));
        }
    }
}
