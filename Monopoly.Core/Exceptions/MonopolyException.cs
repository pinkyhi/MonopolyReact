namespace Monopoly.Core.Exceptions
{
    using System;
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class MonopolyException : Exception
    {
        public MonopolyException()
            : base(ErrorMessages.Unknown)
        {
        }

        public MonopolyException(string message)
            : base(message)
        {
        }

        public int Code => (int)ErrorCodesEnums.Global.Unknown;
    }
}