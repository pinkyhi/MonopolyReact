namespace Monopoly.DAL.Entities.GameEntities.Groups
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class MultiplyMonopoly : BaseEntity
    {
        public string Name { get; set; }

        public double BaseMultiplier { get; set; }

        public double MonopolyMultipier { get; set; }

        public double IterationDivider { get; set; }
    }
}