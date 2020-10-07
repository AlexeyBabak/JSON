using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;

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
            
            string personJSON = null;

            try
            {
                personJSON = SerializeJSON(person);
            }
            catch (CustomException exception) when (personJSON == null)
            {
                throw exception;
            }
            finally
            {
                Console.WriteLine(personJSON);
            }

            Console.ReadKey();

        }

        public static string SerializeJSON(Person person)
        {
            var titleList = person.GetType().GetProperties();
            var jsonList = new List<string>();

            foreach (var item in titleList)
            {
                if (item.GetCustomAttribute<IgnoreAttribute>() == null)
                {
                    string line = item.Name + ": " + item.GetValue(person);
                    jsonList.Add(line);
                }
            }

            string json = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
            return json;
        }
    }
}
