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
        public int TableNumber { get; set; }
        public string TableType { get; set; } // "Regular" or "VIP"
        public string TimePlayed { get; set; }
        public double AmountPaid { get; set; }
        public DateTime TimeFinished { get; set; }
        public string CustomerName { get; set; }
    }

    // This is the global logbook that holds all transactions
    public static class GlobalData
    {
        public static List<Transaction> DailyTransactions = new List<Transaction>();
    }
}
