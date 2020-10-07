using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Alexey",
                LastName = "Babak",
                Age = 20
            };
            
            var titleList = person.GetType().GetProperties();

            Console.WriteLine(titleList);
            Console.ReadKey();

        }
    }
}
