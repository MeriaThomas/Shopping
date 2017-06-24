using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    static class Inter
    {
        private static ShoppingModel db = new ShoppingModel();

        public static Account CreateAccount(string name, string emailaddress, string address)
        {
            var account = new Account(name, emailaddress, address);
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static List<Account> GetAllAccounts()
        {
            return db.Accounts.ToList();
        }


        public static Product CreateProduct(string pname, decimal pprice,int quantity)
        {
            var product = new Product();
            product.Pname(pname);
            product.Pprice(pprice);
            product.Deposit(quantity);
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
       
        public static List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public static int Deposit(int pid, int quantity)
        {
            var product = db.Products.Where(p => p.ProductId == pid).FirstOrDefault();
            if (product == null)
                throw new ArgumentException("Product not found");
            var newStock = product.Deposit(quantity);
            db.SaveChanges();
            return newStock;

        }

        public static int Withdraw(int pid, int quantity)
        {
            var product = db.Products.Where(p => p.ProductId == pid).FirstOrDefault();
            if (product == null)
                throw new ArgumentException("Product not found");
             var newStock = product.Withdraw(quantity);
            db.SaveChanges();
            return newStock;

        }

        public static List<History> GetHistoryByAccount (int accountNumber)
        {
            return db.Histories.Where(h => h.AccountNumber == accountNumber).ToList();

        }


    }
}
