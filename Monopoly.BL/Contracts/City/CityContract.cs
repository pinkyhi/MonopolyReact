namespace Monopoly.BL.Contracts.City
{
    using AutoMapper;
    using Monopoly.DAL.Entities;

    [AutoMap(typeof(City), ReverseMap = true)]
    public class CityContract
    {
        public string Name { get; set; }

        public bool Publicity { get; set; }
    }
}