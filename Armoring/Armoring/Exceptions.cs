using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armoring
{
    class InvalidConnectionException : Exception
    {
        private string invalidconnectionexception = "Connection Failed!";
        public InvalidConnectionException(string message = "Connection Failed!") : base(message) { }
    }
}
