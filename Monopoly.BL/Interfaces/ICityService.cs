namespace Monopoly.BL.Interfaces
{
    using Monopoly.BL.Models.City;
    using System.Threading.Tasks;

    public interface ICityService
    {
        Task<CityModel> AddCity();

        void DeleteCity();

        // Streets
        Task<StreetFieldModel> AddStreet();

        void DeleteStreet();

        Task<CityStreetModel> ConnectStreet();

        // Street monopolies
        Task<StreetMonopolyModel> AddStreetMonopoly();

        void DeleteStreetMonopoly();

        void ConnectStreetMonopoly();

        // Event fields
        Task<EventFieldModel> AddEventField();

        void DeleteEventField();

        Task<CityEventFieldModel> ConnectEventField();

        // Movement fields
        Task<MovementFieldModel> AddMovementField();

        void DeleteMovementField();

        Task<CityMovementFieldModel> ConnectMovementField();

        // Movement monopolies
        Task<MovementMonopolyModel> AddMovementMonopoly();

        void DeleteMovementMonopoly();

        void ConnectMovementMonopoly();

        // Multiply fields
        Task<MultiplyFieldModel> AddMultiplyField();

        void DeleteMultiplyField();

        Task<CityMultiplyFieldModel> ConnectMultiplyField();

        // Multiply monoplies
        Task<MultiplyMonopolyModel> AddMuliplyMonopoly();

        void DeleteMultiplyMonopoly();

        void ConnectMultiplyMonopoly();

        // Card groups
        Task<CardGroupModel> AddCardGroup();

        void DeleteCardGroup();

        void ConnectCardGroup();

        // Cards
        Task<CardModel> AddCard();

        void DeleteCard();

        Task<CityCardModel> ConnectCard();
    }
}