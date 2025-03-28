using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Customer : Person
    {

        public List<Sales> PurschesList = new List<Sales>();
        public Customer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }


        public void Introduce()
        {
            Console.WriteLine($"Iam a customer: {this._firstName} {this._lastName}");
        }
    }
}
