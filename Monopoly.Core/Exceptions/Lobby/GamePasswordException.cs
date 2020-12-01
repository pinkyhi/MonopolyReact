namespace Monopoly.Core.Exceptions.Lobby
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class GamePasswordException : BaseAppException
    {
        public GamePasswordException()
            : base(ErrorMessages.GamePasswordException)
        {
        }

        public GamePasswordException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Lobby.GameWrongPassword;
    }
}