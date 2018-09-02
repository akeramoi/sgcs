using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Http;
using SocialGoodCurrencyServices.Models;

namespace SocialGoodCurrencyServices.Controllers
{
    public class TransactionsController : ApiController
    {
        
        Transactions[] transactions = new Transactions[]
        {
            new Transactions { TransactionID = 1, CustomerID = 122332, TokenID = 233, ProductID = 1,  ActionAbbrev = "Whittle Me Bob", Amount= 12},
            new Transactions { TransactionID = 2, CustomerID = 122332, TokenID = 234, ProductID = 2,  ActionAbbrev = "Down Under Mate", Amount= 100},
            new Transactions { TransactionID = 3, CustomerID = 122332, TokenID = 235, ProductID = 3,  ActionAbbrev = "Up Fin Way", Amount= 1200},

        };

      

        public IEnumerable<Transactions> GetAllTransactions()
        {
            return transactions;
        }

        public IHttpActionResult GetTransactions(int id)
        {
            var transaction = transactions.FirstOrDefault((p) => p.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }
    }
}




