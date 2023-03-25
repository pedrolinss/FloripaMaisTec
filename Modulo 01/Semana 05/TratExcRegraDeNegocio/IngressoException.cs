using System;
namespace TratExcRegraDeNegocio
{
    public class IngressoException : Exception
    {
        public IngressoException()
        {

        }

        public IngressoException(string message) : base(message)
        {

        }

        public IngressoException(string message, Exception causaExcetion) : base(message,causaExcetion)
        {

        }
    }
}

