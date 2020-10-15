namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class RefreshTokenNotFoundException : MonopolyException
    {
        public RefreshTokenNotFoundException()
           : base(ErrorMessages.RefreshTokenNotFoundException)
        {
        }

        public RefreshTokenNotFoundException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.NotFoundRefreshToken;
    }
}