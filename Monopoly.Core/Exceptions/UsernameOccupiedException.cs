namespace Monopoly.Core.Exceptions
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class UsernameOccupiedException : MonopolyException
    {
        public UsernameOccupiedException()
            : base(ErrorMessages.UsernameOccupiedException)
        {
        }

        public UsernameOccupiedException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Registration.UsernameOccupied;
    }
}