namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class InvalidPasswordException : BaseAppException
    {
        public InvalidPasswordException()
            : base(ErrorMessages.InvalidPasswordException)
        {
        }

        public InvalidPasswordException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Login.InvalidPassword;
    }
}