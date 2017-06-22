using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    enum PaymentTypes
    {
        Credit,
        Debit
    }

    class Payment
    {
        #region Properties
        public PaymentTypes PaymentType { get; set; }

        public int CardNumber { get; set; }

        public string CardName { get; set; }

        public DateTime ExpDate { get; set; }

        public int CCV { get; set; }

        public string CardHoldersAddress { get; set; }
        #endregion



    }
}
