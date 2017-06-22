using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Account
    {
        #region Variables
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }
        [Key]
        public int AccountNumber { get; private set; }

        public virtual ICollection<History> Histories { get; set; }

        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
        }

        public Account(string name) : this()
        {
            Name = name;
        }
        public Account(string name,string emailaddress,string address) : this(name)
        {
            EmailAddress = emailaddress;
            Address = address;
        }

        #endregion
    }
}
