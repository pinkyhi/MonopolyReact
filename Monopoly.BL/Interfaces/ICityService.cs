namespace Monopoly.BL.Interfaces
{
    using System.Threading.Tasks;
    using Monopoly.BL.Contracts.City;
    using Monopoly.BL.Models.City;

    public interface ICityService
    {
        public Task ConnectCards(int cityId, int cardGroupId);

        public Task<CityCardModel> ChangeCityCardArguments(int cityCardId, string arguments);

        public Task<CardModel> AddCard(CardModel model);

        public Task<CardGroupModel> AddCardGroup(CardGroupModel model);

        public Task<CityModel> AddCity(CityContract model);

        public Task<EventFieldModel> AddEventField(EventFieldModel model);

        public Task<MovementFieldModel> AddMovementField(MovementFieldModel model);

        public Task<MovementMonopolyModel> AddMovementMonopoly(MovementMonopolyModel model);

        public Task<MultiplyMonopolyModel> AddMuliplyMonopoly(MultiplyMonopolyModel model);

        public Task<MultiplyFieldModel> AddMultiplyField(MultiplyFieldModel model);

        public Task<StreetFieldModel> AddStreet(StreetFieldModel model);

        public Task<StreetMonopolyModel> AddStreetMonopoly(StreetMonopolyModel model);

        public Task<CityEventFieldModel> ConnectEventField(CityEventFieldContract contract);

        public Task<CityMovementFieldModel> ConnectMovementField(CityMovementFieldContract contract);

        public Task<CityMultiplyFieldModel> ConnectMultiplyField(CityMovementFieldContract contract);

        public Task<CityStreetModel> ConnectStreet(CityStreetContract contract);

        public Task DeleteCard(int cardId);

        public Task DeleteCardGroup(int cardGroupId);

        public Task DeleteCity(int cityId);

        public Task DeleteEventField(int eventFieldId);

        public Task DeleteMovementField(int movementFieldId);

        public Task DeleteMovementMonopoly(int movementMonopolyId);

        public Task DeleteMultiplyField(int multiplyFieldId);

        public Task DeleteMultiplyMonopoly(int multiplyMonopolyId);

        public Task DeleteStreet(int streetId);

        public Task DeleteStreetMonopoly(int streetMonopolyId);
    }
}