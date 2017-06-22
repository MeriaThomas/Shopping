using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    
    public class History
    {
        public int HistoryId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int CardNumber { get; set; }

        public int AccountNumber { get; set; }

        public virtual Account history { get; set; }
    }
}
