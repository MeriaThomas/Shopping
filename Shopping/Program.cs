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
                Console.WriteLine("2. Browse & Shop");
                Console.WriteLine("3. Payment");
                Console.WriteLine("4. Return an Item");
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
                        var products = Inter.CreateProduct(pname, pprice);
                                               
                            Console.WriteLine($"Product Id: {products.ProductId}, Product Name {products.ProductName}, Product Price: {products.ProductPrice}, In Stock: {products.InStock}");
                        
                        break;

                    case "3":
                        Console.Write("please choose a payment type: ");
                        var payTypes = Enum.GetNames(typeof(PaymentTypes));
                        for (int i = 0; i < payTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {payTypes[i]}");
                        }
                        var paymenttype = (PaymentTypes)(Convert.ToInt32(Console.ReadLine())-1);
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

                    case "4":
                        break;

                    default:
                        break;

                }
            }

            }
    }
}
