namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class RefreshTokenWrongJtiException : MonopolyException
    {
        public RefreshTokenWrongJtiException()
           : base(ErrorMessages.RefreshTokenWrongJtiException)
        {
        }

        public RefreshTokenWrongJtiException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.WrongJtiRefreshToken;
    }
}