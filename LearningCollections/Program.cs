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

            Console.WriteLine("Changing the List adding new itens\n");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"The list has {names.Count} people in it\n");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //Searching e order
            //var index = names.IndexOf("Felipe");
            //if (index != -1)
            //    Console.WriteLine($"The name {names[index]} is at index {index}");

            //var notFound = names.IndexOf("Not Found");
            //Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            //Para a tela de comando não fechar teste New
            Console.ReadLine();
        }
    }
}
