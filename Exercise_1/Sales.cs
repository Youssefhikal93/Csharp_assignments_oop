using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Sales
    {
        string ProductName { get; set; }
        double price { get; set; }
        Employee Employee { get; set; }
        Customer Customer { get; set; }
        DateTime TransactionDate { get; set; }


        public Sales(string name, double price, Employee employee, Customer customer) 
        {
            this.ProductName = name;
            this.price = price;
            this.Employee = employee;
            this.Customer = customer;
            this.TransactionDate = DateTime.Now;

            AddToList();
        }


        public void AddToList()
        {
            this.Employee.SalesList.Add(this);
            this.Customer.PurschesList.Add(this);
        }

        public override string ToString()
        {
            return $"Name: {this.ProductName}\nPrice: {this.price}\n Employee: {this.Employee.ToString()}\nCustomer: {this.Customer.ToString()}\nDate:{this.TransactionDate}";
        }

    }
}
