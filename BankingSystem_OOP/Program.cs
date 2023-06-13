using BankingSystem_OOP;

class Program
{
    public static void Main(string[] args)
    {
        ChequeAccount chequeAccount = new ChequeAccount("1", "Rosey", "rose@gmail.com","we", 123, "Cheque", 100 );

        Console.WriteLine("Transfer Amount");
        Console.WriteLine(chequeAccount.TransferMoney(20));

        Console.WriteLine("Check balance month end");
        Console.WriteLine(chequeAccount.CheckBalance());

        Console.WriteLine("Withdraw money");
        Console.WriteLine(chequeAccount.WithdrawMoney(20));

        Console.WriteLine("Amount to deposit");
        Console.WriteLine(chequeAccount.DepositMoney(20));

        Console.ReadKey();
    }
}
