namespace Monopoly.BL.Contracts.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities;

    [AutoMap(typeof(City))]
    public class CityContract
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Publicity { get; set; }
    }
}