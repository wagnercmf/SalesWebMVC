using System;

namespace SalesWebMVC.Services.Exeptions
{
    public class NotFoundExeption : ApplicationException 
    {
        public NotFoundExeption(string message) : base(message)
        {

        }
    }
}
