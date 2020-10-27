namespace Monopoly.BL.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Monopoly.BL.Contracts.City;
    using Monopoly.BL.Interfaces;
    using Monopoly.BL.Models.City;
    using Monopoly.DAL.Entities;
    using Monopoly.DAL.Entities.GameEntities;
    using Monopoly.DAL.Entities.GameEntities.Cards;
    using Monopoly.DAL.Entities.GameEntities.Groups;
    using Monopoly.DAL.Entities.JoinEntities;
    using Monopoly.DAL.Interfaces;

    public class CityService : ICityService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CityService(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CityModel> GetCity(int cityId)
        {
            City result = await this.repository.GetAsync<City>(false,
                c => c.Id == cityId,
                c => c.CityStreets,
                c => c.CityMultiplyFields,
                c => c.CityMovementFields,
                c => c.CityEventFields,
                c => c.CityCards,
                c => c.CityCards.Select(s => s.EventCard),
                c => c.CityCards.Select(s => s.EventCard.CardGroup),
                c => c.CityStreets.Select(s => s.Street),
                c => c.CityStreets.Select(s => s.Street.StreetMonopoly),
                c => c.CityMultiplyFields.Select(s => s.MultiplyField),
                c => c.CityMultiplyFields.Select(s => s.MultiplyField.MultiplyMonopoly),
                c => c.CityMovementFields.Select(s => s.MovementField),
                c => c.CityMovementFields.Select(s => s.MovementField.MovementMonopoly),
                c => c.CityEventFields.Select(s => s.EventField));
            return this.mapper.Map<CityModel>(result);
        }

        public async Task ConnectCards(int cityId, int cardGroupId)
        {
            IEnumerable<EventCard> cards = await this.repository.GetRangeAsync<EventCard>(false, c => c.CardGroupId == cardGroupId);
            IEnumerable<CityCard> cityCards = new List<CityCard>();
            foreach (EventCard card in cards)
            {
                cityCards.Append(new CityCard() { CardId = card.Id, CityId = cityId });
            }

            await this.repository.AddRangeAsync(cityCards);
        }

        public async Task<CityCardModel> ChangeCityCardArguments(int cityCardId, string arguments)
        {
            CityCard card = await this.repository.GetAsync<CityCard>(false, c => cityCardId == c.Id);
            card.Arguments = arguments;
            await this.repository.UpdateAsync(card);
            return this.mapper.Map<CityCardModel>(card);
        }

        public async Task<CardModel> AddCard(CardModel model)
        {
            EventCard result = await this.repository.AddAsync(this.mapper.Map<EventCard>(model));
            return this.mapper.Map<CardModel>(result);
        }

        public async Task<CardGroupModel> AddCardGroup(CardGroupModel model)
        {
            CardGroup result = await this.repository.AddAsync(this.mapper.Map<CardGroup>(model));
            return this.mapper.Map<CardGroupModel>(result);
        }

        public async Task<CityModel> AddCity(CityContract model)
        {
            City result = await this.repository.AddAsync(this.mapper.Map<City>(model));
            return this.mapper.Map<CityModel>(result);
        }

        public async Task<EventFieldModel> AddEventField(EventFieldModel model)
        {
            EventField result = await this.repository.AddAsync(this.mapper.Map<EventField>(model));
            return this.mapper.Map<EventFieldModel>(result);
        }

        public async Task<MovementFieldModel> AddMovementField(MovementFieldModel model)
        {
            MovementField result = await this.repository.AddAsync(this.mapper.Map<MovementField>(model));
            return this.mapper.Map<MovementFieldModel>(result);
        }

        public async Task<MovementMonopolyModel> AddMovementMonopoly(MovementMonopolyModel model)
        {
            MovementMonopoly result = await this.repository.AddAsync(this.mapper.Map<MovementMonopoly>(model));
            return this.mapper.Map<MovementMonopolyModel>(result);
        }

        public async Task<MultiplyMonopolyModel> AddMuliplyMonopoly(MultiplyMonopolyModel model)
        {
            MultiplyMonopoly result = await this.repository.AddAsync(this.mapper.Map<MultiplyMonopoly>(model));
            return this.mapper.Map<MultiplyMonopolyModel>(result);
        }

        public async Task<MultiplyFieldModel> AddMultiplyField(MultiplyFieldModel model)
        {
            MultiplyField result = await this.repository.AddAsync(this.mapper.Map<MultiplyField>(model));
            return this.mapper.Map<MultiplyFieldModel>(result);
        }

        public async Task<StreetFieldModel> AddStreet(StreetFieldModel model)
        {
            StreetField result = await this.repository.AddAsync(this.mapper.Map<StreetField>(model));
            return this.mapper.Map<StreetFieldModel>(result);
        }

        public async Task<StreetMonopolyModel> AddStreetMonopoly(StreetMonopolyModel model)
        {
            StreetMonopoly result = await this.repository.AddAsync(this.mapper.Map<StreetMonopoly>(model));
            return this.mapper.Map<StreetMonopolyModel>(result);
        }

        public async Task<CityEventFieldModel> ConnectEventField(CityEventFieldContract contract)
        {
            CityEventField result = await this.repository.AddAsync(this.mapper.Map<CityEventField>(contract));
            return this.mapper.Map<CityEventFieldModel>(result);
        }

        public async Task<CityMovementFieldModel> ConnectMovementField(CityMovementFieldContract contract)
        {
            CityMovementField result = await this.repository.AddAsync(this.mapper.Map<CityMovementField>(contract));
            return this.mapper.Map<CityMovementFieldModel>(result);
        }

        public async Task<CityMultiplyFieldModel> ConnectMultiplyField(CityMovementFieldContract contract)
        {
            CityMultiplyField result = await this.repository.AddAsync(this.mapper.Map<CityMultiplyField>(contract));
            return this.mapper.Map<CityMultiplyFieldModel>(result);
        }

        public async Task<CityStreetModel> ConnectStreet(CityStreetContract contract)
        {
            CityStreet result = await this.repository.AddAsync(this.mapper.Map<CityStreet>(contract));
            return this.mapper.Map<CityStreetModel>(result);
        }

        public async Task DeleteCard(int cardId)
        {
            EventCard card = await this.repository.GetAsync<EventCard>(false, c => c.Id == cardId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteCardGroup(int cardGroupId)
        {
            CardGroup card = await this.repository.GetAsync<CardGroup>(false, c => c.Id == cardGroupId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteCity(int cityId)
        {
            City card = await this.repository.GetAsync<City>(false, c => c.Id == cityId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteEventField(int eventFieldId)
        {
            EventField card = await this.repository.GetAsync<EventField>(false, c => c.Id == eventFieldId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteMovementField(int movementFieldId)
        {
            MovementField card = await this.repository.GetAsync<MovementField>(false, c => c.Id == movementFieldId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteMovementMonopoly(int movementMonopolyId)
        {
            MovementMonopoly card = await this.repository.GetAsync<MovementMonopoly>(false, c => c.Id == movementMonopolyId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteMultiplyField(int multiplyFieldId)
        {
            MultiplyField card = await this.repository.GetAsync<MultiplyField>(false, c => c.Id == multiplyFieldId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteMultiplyMonopoly(int multiplyMonopolyId)
        {
            MultiplyMonopoly card = await this.repository.GetAsync<MultiplyMonopoly>(false, c => c.Id == multiplyMonopolyId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteStreet(int streetId)
        {
            StreetField card = await this.repository.GetAsync<StreetField>(false, c => c.Id == streetId);
            await this.repository.DeleteAsync(card);
        }

        public async Task DeleteStreetMonopoly(int streetMonopolyId)
        {
            StreetMonopoly card = await this.repository.GetAsync<StreetMonopoly>(false, c => c.Id == streetMonopolyId);
            await this.repository.DeleteAsync(card);
        }
    }
}