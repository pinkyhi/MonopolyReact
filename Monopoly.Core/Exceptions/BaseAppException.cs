namespace Monopoly.Core.Exceptions
{
    using System;
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class BaseAppException : Exception
    {
        public BaseAppException()
            : base(ErrorMessages.Unknown)
        {
        }

        public BaseAppException(string message)
            : base(message)
        {
        }

        public virtual int Code => (int)ErrorCodesEnums.Global.Unknown;
    }
}