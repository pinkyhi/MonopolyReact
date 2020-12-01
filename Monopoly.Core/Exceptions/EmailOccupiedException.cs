namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class EmailOccupiedException : BaseAppException
    {
        public EmailOccupiedException()
           : base(ErrorMessages.EmailOccupiedException)
        {
        }

        public EmailOccupiedException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Registration.EmailOccupied;
    }
}