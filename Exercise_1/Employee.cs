using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Employee : Person
    {
        private int _salary { get; set; }
        public List<Sales> SalesList = new List<Sales>();


        public Employee(string firstName, string lastName, int age, int salary) : base(firstName, lastName, age)
        {
            this._salary = salary;
        }

        public void Introduce()
        {
            Console.WriteLine($"Iam an emplyee: {this._firstName} {this._lastName}");
        }
    }
}
 