namespace BankingSystem_OOP
{
    public abstract class AbstractAccount
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;
        private int _accountNumber;
        private string _accountType;

        public AbstractAccount(string id, string name, string email, string password, int accountNumber, string accountType)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _accountNumber = accountNumber;
            _accountType = accountType;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        public abstract decimal DepositMoney(decimal amountToDeposit);
        public abstract decimal WithdrawMoney(decimal amountToWithdraw);
        public abstract decimal TransferMoney(decimal amountToTransfer);
        public abstract decimal CheckBalance();

        public override string ToString()
        {
            return base.ToString() + $"{Id}\n{Name}\n{AccountNumber}\n{AccountType}";
        }

    }
}
