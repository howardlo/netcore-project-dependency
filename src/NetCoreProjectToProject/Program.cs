using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryB;

namespace NetCoreProjectToProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The main project depends on ClassLibraryB which depends on ClassLibraryA");
            Console.WriteLine();

            var classb = new ClassB();

            Console.WriteLine($"classb.Say: {classb.Say}");
            Console.WriteLine();

            Console.WriteLine($"press enter to continue:");
            Console.ReadLine();
        }
    }
}
