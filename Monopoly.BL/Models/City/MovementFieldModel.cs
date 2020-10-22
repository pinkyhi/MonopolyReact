namespace Monopoly.BL.Models.City
{
    public class MovementFieldModel
    {
        public int Id { get; set; }

        public string DefaultName { get; set; }

        public int MovementMonopolyId { get; set; }

        public MovementMonopolyModel MovementMonopoly { get; set; }
    }
}