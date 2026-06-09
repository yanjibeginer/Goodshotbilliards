using System;
using System.Data.SQLite;
using System.IO;

namespace Goodshotbilliards 
{
    public static class DatabaseHelper
    {
        
        private static string dbFileName = "BilliardsDB.sqlite";
        public static string ConnectionString = $"Data Source={dbFileName};Version=3;";

        public static void InitializeDatabase()
        {
            // If the file doesn't exist yet, create it!
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    // Build the Transactions table
                    string createTableQuery = @"
                        CREATE TABLE Transactions (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            TableNumber INTEGER,
                            TableType TEXT,
                            TimePlayed TEXT,
                            AmountPaid REAL,
                            TimeFinished DATETIME,
                            CustomerName TEXT
                        )";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    // Build the Reservations table
                    string createReservationsQuery = @"
                        CREATE TABLE IF NOT EXISTS Reservations (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            CustomerName TEXT,
                            TableNumber TEXT,
                            Date TEXT,
                            Time TEXT
                        )";

                    using (var command2 = new SQLiteCommand(createReservationsQuery, connection))
                    {
                        command2.ExecuteNonQuery();
                    }
                    // Build the Settings table and insert the master row
                        string createSettingsQuery = @"
                            CREATE TABLE IF NOT EXISTS Settings (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                AdminPassword TEXT
                            );
                            INSERT OR IGNORE INTO Settings (Id, AdminPassword) 
                            VALUES (1, 'admin123');";

                    using (var command3 = new System.Data.SQLite.SQLiteCommand(createSettingsQuery, connection))
                    {
                        command3.ExecuteNonQuery();
                    }

                }
            }
        }
    }
}