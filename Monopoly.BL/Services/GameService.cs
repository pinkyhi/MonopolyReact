namespace Monopoly.BL.Services
{
    using Monopoly.BL.Interfaces;
    using Monopoly.DAL.Interfaces;

    public class GameService : IGameService
    {
        private readonly IRepository repository;

        public GameService(IRepository repository)
        {
            this.repository = repository;
        }
    }
}