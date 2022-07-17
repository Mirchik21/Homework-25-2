namespace Homework_25_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank<Account> bank = new Bank<Account>();
            bank.PrintAccount(new Account("Account:13500012256743", 5000));

            Bank<DepositAccount> bankDeposit = new Bank<DepositAccount>();
            bankDeposit.PrintAccount(new DepositAccount("Deposit Account:13500022256976", 2000));

            Bank<TransitAccount> bankTransit = new Bank<TransitAccount>();
            bankTransit.PrintAccount(new TransitAccount("Transit Account:13500032256456", 1000));

            Bank<ClosedAccount> bankClosed = new Bank<ClosedAccount>();
            bankClosed.PrintAccount(new ClosedAccount("Closed Account:13500042256777", 50));
        }
    }


    class Bank<T> where T : Account
    {
        public void PrintAccount(Account account)
        {
            Console.WriteLine($"On bank account {account.name}, the balance of monetary units is {account.amountOfMoney} US dollars");
        }
    }


    class Account
    {
        public string name { get; set; }
        public int amountOfMoney { get; set; }
        public Account(string Name, int AmountOfMoney)
        {
            this.name = Name;
            this.amountOfMoney = AmountOfMoney;
        }
       


    }

    class DepositAccount : Account
    {
        public DepositAccount(string Name, int AmountOfMoney) :base (Name, AmountOfMoney) { }
       
    }
    class TransitAccount : Account
    {
        public TransitAccount(string Name, int AmountOfMoney) : base(Name, AmountOfMoney) { }
       
    }
    class ClosedAccount : Account
    {
        public ClosedAccount(string Name, int AmountOfMoney) : base(Name, AmountOfMoney) { }

    }

}
