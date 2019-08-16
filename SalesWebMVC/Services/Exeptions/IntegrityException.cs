using System;

namespace SalesWebMVC.Services.Exeptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }

    }
}
