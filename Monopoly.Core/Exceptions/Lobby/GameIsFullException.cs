namespace Monopoly.Core.Exceptions.Lobby
{
    using Monopoly.Core.Enums;
    using Monopoly.Core.Resources;

    public class GameIsFullException : MonopolyException
    {
        public GameIsFullException()
            : base(ErrorMessages.GameIsFullException)
        {
        }

        public GameIsFullException(string message)
            : base(message)
        {
        }

        public override int Code => (int)ErrorCodesEnums.Lobby.GameIsFull;
    }
}