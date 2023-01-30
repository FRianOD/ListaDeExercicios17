using System;
namespace ListaDeExercicios17.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {

        }
    }
}
