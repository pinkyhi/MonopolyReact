namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class RefreshTokenIsInvalidatedException : BaseAppException
    {
        public RefreshTokenIsInvalidatedException()
           : base(ErrorMessages.RefreshTokenIsInvalidatedException)
        {
        }

        public RefreshTokenIsInvalidatedException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Token.InvalidatedRefreshToken;
    }
}