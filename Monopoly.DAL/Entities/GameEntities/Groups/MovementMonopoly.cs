namespace Monopoly.DAL.Entities.GameEntities.Groups
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class MovementMonopoly : BaseEntity
    {
        public string Name { get; set; }

        public int BaseTax { get; set; }

        public double MonopolyMultiplier { get; set; }

        public double IterationDivider { get; set; }
    }
}