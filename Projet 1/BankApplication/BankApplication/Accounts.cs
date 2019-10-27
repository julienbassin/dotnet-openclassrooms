using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        //compte joint qui appartient à plusieurs utilisateurs
        //impossible de supprimer un compter courant , vérifier qu'il reste 20 euros
        //possibilité le compte épargne a partir de x années (paramètre)
        public int AccountId { get; set; } = 3;
        public decimal Balance { get; set; }
        public decimal Saving { get; set; }
        public decimal Amount { get; set; }


        public Account() { }

        public Account(int ClientAccountId) { }

        public Account(int ClientAccountId, decimal ClientAmount = 0)
        {
            AccountId = ClientAccountId;
            Amount = ClientAmount;
        }

        public string GetAccountInfo(string AccountName)
        {

            return $"The account of {AccountName} has {this.Amount}";
        }

        //ajouter une vérification check if balance positif ou non ? 
        public decimal BalanceChecking()
        {
            return Balance;
        }

        public decimal AddMoney(decimal amount)
        {

            Balance += amount;
            return Balance;
        }

        public decimal WithDrawMoney(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        //date de creation du compte à vérifier pour vérifier de retirer de l'argent 
        //si date de creation a mons d'un an
        public decimal BalanceSaving()
        {
            return Saving;
        }

        public decimal AddSavingMoney(decimal amount)
        {

            Saving += amount;
            return Saving;
        }

        public decimal WithDrawSavingMoney(decimal amount)
        {
            Saving -= amount;
            return Saving;
        }

        //methode qui enfonction du resultat ajoute des ajiots etc ...
    }
}
