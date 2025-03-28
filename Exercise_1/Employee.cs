using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise_1
{
    public class Employee : Person
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

        public void statistics ()
        {
            Console.WriteLine($"Total number of sales: {getNumberOfSales()}"); 
            Console.WriteLine($"Total amount of sales: {TotalSalesForEmployee()}"); 
            GetAverageSale();
        }

        public void PrintSalesList()
        {
            Console.WriteLine($"Staff name: {this._firstName}"); 
            foreach (var sale in SalesList)
            {
                Console.WriteLine($"Product name:{sale.ProductName}\tPrice: {sale.price}\t Buyer:{sale.Customer._firstName}");
            }
        }


        private int getNumberOfSales()
        {
            //Console.WriteLine($"Total number of sales: {SalesList.Count}");
            return SalesList.Count;
        }

        private double TotalSalesForEmployee()
        {
            double totalPrice=0;

            foreach(var sale in SalesList)
            {
                totalPrice += sale.price;
            }

            //Console.WriteLine($"Total sales amount: {totalPrice}");
            return totalPrice;
        }

        private  void GetAverageSale()
        {
            Console.WriteLine($"Avarge sales: {TotalSalesForEmployee()/getNumberOfSales()}");
        }

        
    }
}
 