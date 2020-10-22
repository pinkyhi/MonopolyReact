namespace Monopoly.BL.Models.City
{
    public class MovementMonopolyModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BaseTax { get; set; }

        public double MonopolyMultiplier { get; set; }

        public double IterationDivider { get; set; }
    }
}