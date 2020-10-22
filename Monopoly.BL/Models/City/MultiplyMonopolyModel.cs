namespace Monopoly.BL.Models.City
{
    public class MultiplyMonopolyModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double BaseMultiplier { get; set; }

        public double MonopolyMultipier { get; set; }

        public double IterationDivider { get; set; }
    }
}