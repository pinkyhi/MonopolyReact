namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class InvalidRefreshTokenException : BaseAppException
    {
        public InvalidRefreshTokenException()
           : base(ErrorMessages.InvalidRefreshTokenException)
        {
        }

        public InvalidRefreshTokenException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.InvalidRefreshToken;
    }
}