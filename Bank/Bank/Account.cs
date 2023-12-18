using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank
{
    public class Account
    {
        public List<Account> accounts;
        public string AccountNumber { get; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
        
        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Transactions = new List<Transaction>();
            accounts = new List<Account>();
        }

        private static readonly Random random = new Random();
        private const string chars = "0123456789";

        public static string GenerateAccountNumber(List<User> users)
        {
            string accountNumber;
            do
            {
                accountNumber = new string(Enumerable.Repeat(chars, 8)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            while (AccountNumberExists(accountNumber,users)); 

            return accountNumber;
        }

        private static bool AccountNumberExists(string accountNumber, List<User> users)
        {
            foreach (var user in users)
            {
                foreach (var account in user.Accounts)
                {
                    if (account.AccountNumber == accountNumber)
                    {
                        return true; 
                    }
                }
            }
            return false; 
        }
        public static Account CreateNewAccount(List<User> users, User user)
        {
            Account newAccount = new Account(Account.GenerateAccountNumber(users), 0); 
            user.Accounts.Add(newAccount); 
            return newAccount; 
        }
        public List<Account> GetAccounts()
        {
            return accounts;

        }
        public void MakePayment(string receiverAccountNumber, string ocrNumber, decimal amount,DateTime paymentOperationDate)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transaction newTransaction = new Transaction("Payment", amount, DateTime.Now, null, receiverAccountNumber, ocrNumber);
                Transactions.Add(newTransaction); 

            }
            else
            {
                MessageBox.Show("Balance is not sufficient for payment");
            }
        }
    }
}
