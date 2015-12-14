using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some text and more shit");
            Person p = new Person() { FirstName = "Itay", LastName = "Tal" };
            Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }
}
