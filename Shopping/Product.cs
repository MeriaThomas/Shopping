using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Product
    {
        #region Variables
        private static int lastPid = 0;
        #endregion

        #region Properties
        [Key]
        public int ProductId { get; private set; }

        public string ProductName { get; private set; }

        public decimal ProductPrice { get; private set; }

        public int InStock { get; private set; }
        #endregion

        #region Constructors
        public Product()
        {
            ProductId = ++lastPid;
        }

        //public Product (string pname) : this()
        //{
        //    ProductName = pname;
        //}

        //public Product (string pname, decimal pprice) : this(pname)
        //{
        //    ProductPrice = pprice; 
        //}

        //public Product(int pid, string pname, decimal pprice)
        //{
        //    this.pid = pid;
        //    this.pname = pname;
        //    this.pprice = pprice;
        //}

        //public Product(int pid)
        //{
        //    this.pid = pid;
        //}



        #endregion

        #region Methods
        public string Pname(string name)
        {
            ProductName = name;
            return name;
        }

        public decimal Pprice(decimal price)
        {
            ProductPrice = price;
            return price;
        }

        public int Deposit(int quantity)
        {
            InStock += quantity;
            return quantity;
        }

        public int Withdraw(int quantity)
        {
            InStock -= quantity;
            return quantity;
        }

        #endregion
    }
}
