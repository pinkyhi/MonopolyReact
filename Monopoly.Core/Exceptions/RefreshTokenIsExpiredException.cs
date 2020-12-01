namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class RefreshTokenIsExpiredException : BaseAppException
    {
        public RefreshTokenIsExpiredException()
           : base(ErrorMessages.RefreshTokenIsExpiredException)
        {
        }

        public RefreshTokenIsExpiredException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.ExpiredRefreshToken;
    }
}