using System;
namespace SocialGoodCurrencyServices.Models
{
    public class Transactions
    {


        public int TransactionID { get; set; }

        public int CustomerID { get; set; }

        public int TokenID { get; set; } 

        public int ProductID { get; set; } 

        public DateTime ActionDate { get; set; }  

        public string ActionAbbrev { get; set; } 

        public double Amount { get; set; }

    }
}
