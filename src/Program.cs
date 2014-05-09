using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Name = "Jeffery",
                LastLoginDate = new DateTime(2009, 11, 2, 19, 23, 32)
            };

            var template = new CustomerEmailTemplate();
            template.Session = new Dictionary<string, object>()
            {
                { "Customer", customer }
            };

            template.Initialize();
            Console.WriteLine(template.TransformText());
        }
    }
}
