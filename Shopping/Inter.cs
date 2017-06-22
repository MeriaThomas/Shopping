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


        public static Product CreateProduct(int pid,string pname, decimal pprice)
        {
            var product = new Product(pid);
            product.Pname(pname);
            product.Pprice(pprice);
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
       
        public static List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

     
    }
}
