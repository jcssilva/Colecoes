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

            Console.ReadLine();
        }
    }
}
