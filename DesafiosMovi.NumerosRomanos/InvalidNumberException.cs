using System;
using System.Collections.Generic;
using System.Text;

namespace DesafiosMovi.NumerosRomanos
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string Message) : base(Message)
        {

        }
    }
}
