using ListaDeExercicios17.Entities.Exceptions;
namespace ListaDeExercicios17.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account ()
        {

        }

        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount >= WithdrawLimit)
            {
                throw new WithdrawException("Error! A retirada não pode ser feita, o valor informado foi maior doque o limite de retirada.");
            }
            if (Balance-amount <= 0)
            {
                throw new WithdrawException("Error! A retirada não pode ser feita, o valor informado foi maior doque a quantidade que possuia na conta.");
            }
            Balance -= amount;
        }
    }
}
