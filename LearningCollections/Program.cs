using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<String> { "Joseph", "Mark", "Robert" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");

            }

            Console.WriteLine("Changin the List");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            //Para a tela de comando não fechar teste New
            Console.ReadLine();
        }
    }
}
