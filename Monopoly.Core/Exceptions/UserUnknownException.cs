namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class UserUnknownException : BaseAppException
    {
        public UserUnknownException()
            : base(ErrorMessages.UserUnknownException)
        {
        }

        public UserUnknownException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Login.UserUnknown;
    }
}