namespace Monopoly.BL.Models.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities.GameEntities;

    [AutoMap(typeof(MultiplyField))]
    public class MultiplyFieldModel
    {
        public int Id { get; set; }

        public string DefaultName { get; set; }

        public int MultiplyMonopolyId { get; set; }

        public MultiplyMonopolyModel MultiplyMonopoly { get; set; }
    }
}