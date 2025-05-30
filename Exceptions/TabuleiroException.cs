using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }
        public TabuleiroException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public TabuleiroException() : base("Erro no tabuleiro!")
        {

        }
    }
}
