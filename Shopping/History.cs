using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    
    public class History
    {
        [Key]
        public int HistoryId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        [ForeignKey("Account")]
        public int AccountNumber { get; set; }

        public virtual Account history { get; set; }
    }
}
