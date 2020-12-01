namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class RefreshTokenIsUsedException : BaseAppException
    {
        public RefreshTokenIsUsedException()
           : base(ErrorMessages.RefreshTokenIsUsedException)
        {
        }

        public RefreshTokenIsUsedException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.UsedRefreshToken;
    }
}