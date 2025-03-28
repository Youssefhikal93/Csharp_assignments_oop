using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Person
    {
        protected int _age { get; set; }
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }
        private static int _instancesCount = 0;

        public Person(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            _instancesCount++;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, My {this._firstName} {this._lastName}.");
        }

        public override string ToString()
        {
            return $"({_firstName},{_lastName},{_age})";
        }

        public void CountOfInstances()
        {
            Console.WriteLine($"{_instancesCount} instances has been created.");
        }
    }
}
