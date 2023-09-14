using System;

namespace ExercFixBankAccount.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {

        }
    }
}
