using JPathFilesApp15.Task4Files;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPathFilesApp15
{
    internal class SplitJSONFile
    {
        private const string TransactionsFile = "transactions.json";
        private const string CreditsFile = "credits.json";
        private const string DebitsFile = "debits.json";
        public void SplitJSONFileByKey()
        {
            // Load transactions from JSON file
            List<Transaction> transactions = LoadTransactions(TransactionsFile);

            // Split transactions into credits and debits
            var credits = transactions.Where(t => t.Type == "credit").ToList();
            var debits = transactions.Where(t => t.Type == "debit").ToList();

            // Calculate total amounts
            decimal totalCredits = credits.Sum(t => t.Amount);
            decimal totalDebits = debits.Sum(t => t.Amount);

            // Save to separate JSON files
            SaveTransactions(CreditsFile, credits);
            SaveTransactions(DebitsFile, debits);

            // Print results
            Console.WriteLine($"Total Credit Amount: {totalCredits}");
            Console.WriteLine($"Total Debit Amount: {totalDebits}");
            Console.WriteLine($"Credit transactions saved to {CreditsFile}");
            Console.WriteLine($"Debit transactions saved to {DebitsFile}");
        }

        static List<Transaction> LoadTransactions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} not found.");
                return new List<Transaction>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();
        }

        static void SaveTransactions(string filePath, List<Transaction> transactions)
        {
            string json = JsonConvert.SerializeObject(transactions, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
