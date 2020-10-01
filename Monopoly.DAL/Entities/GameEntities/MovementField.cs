namespace Monopoly.DAL.Entities.GameEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class MovementField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int MovementMonopolyId { get; set; }
    }
}