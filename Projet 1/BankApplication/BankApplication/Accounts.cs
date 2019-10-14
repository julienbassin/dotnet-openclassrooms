using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        public int AccountId { get; set; } = 3;
        public decimal Balance { get; set; }
        public decimal Saving { get; set; }
        public decimal Amount { get; set; }

        public Account() { }

        public Account(int ClientAccountId, decimal ClientAmount)
        {
            AccountId = ClientAccountId;
            Amount = ClientAmount;
        }

        public string GetAccountInfo(string AccountName)
        {

            return $"The account of {AccountName} has {this.Amount}";
        }

        public decimal BalanceChecking()
        {
            return Balance;
        }

        public decimal DepositChecking(decimal amount)
        {

            Balance += amount;
            return Balance;
        }

        public decimal WithDrawChecking(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        public decimal BalanceSaving()
        {
            return Saving;
        }

        public decimal DepositSaving(decimal amount)
        {

            Saving += amount;
            return Saving;
        }

        public decimal WithDrawSaving(decimal amount)
        {
            Saving -= amount;
            return Saving;
        }
    }
}
