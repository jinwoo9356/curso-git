using System;

namespace ExceptionExercice.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) :base(message)
        {  
        }
    }
}
