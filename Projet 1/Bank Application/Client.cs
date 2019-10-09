class Client{

    public string _name {get; set;}
    public int _accountId {get; set;}
    public int _amount {get; set;}

    Client(string name, int accountId, int amount){
        _name = name;
        _accountId = accountId;
        _amount = amount;
    }

}