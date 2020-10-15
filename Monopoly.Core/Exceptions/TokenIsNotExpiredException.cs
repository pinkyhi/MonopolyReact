namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class TokenIsNotExpiredException : MonopolyException
    {
        public TokenIsNotExpiredException()
           : base(ErrorMessages.TokenIsNotExpiredExeption)
        {
        }

        public TokenIsNotExpiredException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.IsNotExpired;
    }
}