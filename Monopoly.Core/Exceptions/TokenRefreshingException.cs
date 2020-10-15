namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class TokenRefreshingException : MonopolyException
    {
        public TokenRefreshingException()
           : base(ErrorMessages.TokenRefreshingException)
        {
        }

        public TokenRefreshingException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.RefreshingError;
    }
}