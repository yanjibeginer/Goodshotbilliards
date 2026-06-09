using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goodshotbilliards
{
    public static class BilliardsState
    {


        // 1. The Event (The Megaphone)
        public static event Action OnTableStateChanged;

        // 2. The Trigger (The action of shouting into the megaphone)
        public static void TriggerStateChanged()
        {
            OnTableStateChanged?.Invoke();
        }
        // The core memory bank: Maps "Table 1" through "Table 8" to True (Occupied) or False (Available)
        public static Dictionary<string, bool> TableStatuses = new Dictionary<string, bool>();
        // Tracks who is currently playing at each table: Maps "Table 1" -> "giuan"
        public static Dictionary<string, string> TableAssignments = new Dictionary<string, string>();

        // This runs automatically the very first time the app starts
        static BilliardsState()
        {
            ResetTables();
        }

        public static void ResetTables()
        {
            TableStatuses.Clear();
            TableAssignments.Clear();

            for (int i = 1; i <= 8; i++)
            {
                TableStatuses.Add("Table " + i, false); // All start Available
                TableAssignments.Add("Table " + i, ""); // No players initially
            }
        }
    }
}