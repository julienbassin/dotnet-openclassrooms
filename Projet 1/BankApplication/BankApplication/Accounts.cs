using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        public int _AccountId { get; set; }
        public decimal _Balance { get; set; }
        public decimal _Saving { get; set; }
        public decimal _Amount { get; set; }

        public Account() { }

        public Account(int AccountId, decimal AmountClient)
        {
            _AccountId = AccountId;
            _Amount = AmountClient;
        }

        public string GetAccountInfo(string AccountName)
        {

            return $"The account of {AccountName} has {this._Amount}";
        }

        public decimal BalanceChecking()
        {
            return _Balance;
        }

        public decimal DepositChecking(decimal amount)
        {

            _Balance += amount;
            return _Balance;
        }

        public decimal WithDrawChecking(decimal amount)
        {
            _Balance -= amount;
            return _Balance;
        }

        public decimal BalanceSaving()
        {
            return _Saving;
        }

        public decimal DepositSaving(decimal amount)
        {

            _Saving += amount;
            return _Saving;
        }

        public decimal WithDrawSaving(decimal amount)
        {
            _Saving -= amount;
            return _Saving;
        }
    }
}
