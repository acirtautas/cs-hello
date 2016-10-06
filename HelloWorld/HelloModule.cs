using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HelloModule
    {
        public string SayHello(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Name cannot be empty";
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                return "Surname cannot be empty";
            }

            return string.Format("Hello {0} {1}!", name, surname);
        }
    }
}
