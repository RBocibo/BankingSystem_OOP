namespace BankingSystem_OOP
{
    public class ChequeAccount : AbstractAccount
    {
        private readonly double INTEREST = 0.8;
        private decimal _balance;
        public ChequeAccount(string id, string name, string email, string password, int accountNumber, string accountType, decimal balance)
            : base(id, name, email, password, accountNumber, accountType)
        {
            _balance = balance;
        }
        public sealed override decimal TransferMoney(decimal amountToTransfer)
        {
            _balance = _balance - amountToTransfer;
            return _balance;
        }

        public sealed override decimal WithdrawMoney(decimal amountToWithdraw)
        {
            _balance -= amountToWithdraw;
            return _balance;
        }

        public sealed override decimal CheckBalance()
        {
            decimal addInterest = _balance * (decimal)INTEREST;
            _balance += addInterest;
            return _balance;
        }

        public sealed override decimal DepositMoney(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
            return _balance;
        }

        public virtual string ToString()
        {
            return base.ToString();
        }
    }
}
