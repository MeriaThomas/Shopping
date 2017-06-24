using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Welcome***");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Enter new Product");
                Console.WriteLine("3. Update stock");
                Console.WriteLine("4. Browse and Shop");
                Console.WriteLine("5. Payment");
                Console.WriteLine("6. Browse Products");
                Console.WriteLine("7. History of purchase");
                Console.Write("Please select an option from above: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you!");
                        return;

                    case "1":
                        Console.Write("Name :");
                        var name = Console.ReadLine();
                        Console.Write("Email Address :");
                        var emailaddress = Console.ReadLine();
                        Console.Write("Address :");
                        var address = Console.ReadLine();

                        var account = Inter.CreateAccount(name, emailaddress, address);
                        Console.WriteLine($"AccountNumber: {account.AccountNumber}, Name: {account.Name}, Email Address: {account.EmailAddress}, Address: {account.Address}");
                        break;

                    case "2":
                        Console.Write("Enter Product Name: ");
                        var pname = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        var pprice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number of items in the stock: ");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        
                        var products = Inter.CreateProduct(pname, pprice,quantity);
                                               
                            Console.WriteLine($"Product Id: {products.ProductId}, Product Name {products.ProductName}, Product Price: {products.ProductPrice}, In Stock: {products.InStock}");
                        break;

                    case "3":
                        PrintAllProducts();

                        Console.Write("Enter a product ID to add stock: ");
                        var pid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number of items to the stock: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Inter.Deposit(pid, quantity);
                        break;

                    case "4":
                        PrintAllProducts();

                        Console.Write("Enter Product Id to buy a product: ");
                        pid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the number of items: ");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Inter.Withdraw(pid, quantity);
                        break;

                    case "5":
                        PrintAllProducts();
                        break;

                    case "6":
                        Console.Write("please choose a payment type: ");
                        var payTypes = Enum.GetNames(typeof(PaymentTypes));
                        for (int i = 0; i < payTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {payTypes[i]}");
                        }
                        var paymenttype = (PaymentTypes)(Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.Write("Card Number :");
                        var cardnum = Console.ReadLine();
                        Console.Write("Card Name :");
                        var cardname = Console.ReadLine();
                        Console.Write("CCV :");
                        var ccv = Console.ReadLine();
                        Console.Write("Exp Date : ");
                        var exp = Console.ReadLine();
                        Console.Write("Address to be mailed : ");
                        var cardholdersaddress = Console.ReadLine();
                        break;

                    //case "7":
                    //    Console.Write("Pick an Account Number to see the history of purchase");
                    //    var accountNum = Convert.ToInt32(Console.ReadLine());
                    //    var history = Inter.GetHistoryByAccount(accountNum);

                    //    foreach(var h in history)
                    //    {
                    //        Console.WriteLine($"History Id Id: {h.HistoryId},Product Id {h.HistoryId} Product Name {h.ProductName}, Product Price: {h.ProductPrice}, Purchase Date: {h.PurchaseDate}");
                    //    }
                    //    break;

                    case "7":

                    default:
                        break;

                }
            }

            }

        private static List<Product> PrintAllProducts()
        {
            var pros = Inter.GetAllProducts();
            foreach (var p in pros)
            {
                Console.WriteLine($"Product Id: {p.ProductId}, Product Name {p.ProductName}, Product Price: {p.ProductPrice}, In Stock: {p.InStock}");
            }

            return pros;
        }
    }
}
