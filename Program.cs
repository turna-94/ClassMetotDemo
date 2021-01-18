using System;

namespace BankCustomerTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Atıl",LastName="Tekin",City="İstanbul",Balance=4800.25 };
            Customer customer2 = new Customer { Id = 2, FirstName = "Zeynep", LastName = "Doğan", City = "İzmir", Balance = 7200.75 };
            Customer customer3 = new Customer { Id = 3, FirstName = "Sema", LastName = "Bulut", City = "Bursa", Balance = 3525.45 };
            Customer customer4 = new Customer { Id = 4, FirstName = "Turan", LastName = "Yıldız", City = "Ankara", Balance = 8100.65 };
            Customer customer5 = new Customer { Id = 5, FirstName = "Kemal", LastName = "Çetin", City = "Tekirdağ", Balance = 2800.00 };

            CustomerManager manager = new CustomerManager();

            manager.List(new Customer[] {customer1,customer2,customer3,customer4,customer5});
            manager.Add(new Customer { Id = 6, FirstName = "Melek", LastName = "Bozkurt", City = "Antalya", Balance = 10000.00 });
            manager.Delete(customer5);

        }
    }
}
