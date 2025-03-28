using System.Net.WebSockets;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Youssef","Hikal",30);
            person.Introduce();
            //Person person2 = new Person("Youssef", "Hikal", 30);
            //Person perso = new Person("Youssef", "Hikal", 30);
            //Person pers = new Person("Youssef", "Hikal", 30);
            //Person per = new Person("Youssef", "Hikal", 30);
            //Person pe = new Person("Youssef", "Hikal", 30);

            // printing Obj && After overriding the ToString() 
            Console.WriteLine(person);

            // printing the count of instances
            person.CountOfInstances();


            Customer customer1 = new Customer("Ahmed", "Hikal",35);
            Employee employee1 = new Employee("Nader","Sabry",24,55000);

            customer1.Introduce();
            employee1.Introduce();

            Console.WriteLine(customer1.ToString());
            Console.WriteLine(employee1.ToString());
           

            Sales newSale = new Sales("Cola",150,employee1,customer1);

            Console.WriteLine("******Sales list in the employee (sales)******\n");
            foreach (var sales in employee1.SalesList )
            {
                Console.WriteLine(sales);
            }

            Console.WriteLine("\n**********Sales list in the customer (Purschaes)***********");
            customer1.PurschesList.ForEach(purchase => Console.WriteLine(purchase));

        }
    }
}
