class Account{

    public int AccountId {get; set;}
    public decimal _balance {get; set;}
    public decimal _saving {get; set;}

    Account(){

    }

    public string[] CreateAccount(string name, int accountNumber, int amount){

    }

    public string[] DeleteAccount(string name, int accountNumber){

    }

    public string GetAccountInfo(string acc_name){

        return $"The account of {}"
    }

    public decimal BalanceChecking(){
        return _balance;
    }

    public decimal DepositChecking(decimal amount){

        _balance += amount;
        return _balance;
    }

    public WithDrawChecking(decimal amount){
        _balance -= amount;
        return _balance;
    }

    public decimal BalanceSaving(){
        return _saving;
    }

    public decimal DepositSaving(decimal amount){

        _saving += amount;
        return _saving;
    }

    public WithDrawSaving(decimal amount){
        _saving -= amount;
        return _saving;
    }
}


