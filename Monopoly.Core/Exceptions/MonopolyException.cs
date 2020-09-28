using Monopoly.Core.Enums;
using Monopoly.Core.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core.Exceptions
{
    public class MonopolyException : Exception
    {
        public MonopolyException() : base(ErrorMessages.Unknown)
        {
        }

        public MonopolyException(string message) : base(message)
        {
        }
        public  int Code => (int)ErrorCodesEnums.Global.Unknown;
    }
}
