using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goodshotbilliards
{
    // This represents one finished game
    public class Transaction
    {
        public int TABLE { get; set; }
        public string TYPE { get; set; } // "Regular" or "VIP"
        public string DURATION { get; set; }
        public double AMOUNT { get; set; }
        public DateTime SESSION_END { get; set; }
        public string CUSTOMER { get; set; }
    }

    // This is global logbook that holds all transactions
    public static class GlobalData
    {
        public static List<Transaction> DailyTransactions = new List<Transaction>();
    }
}
