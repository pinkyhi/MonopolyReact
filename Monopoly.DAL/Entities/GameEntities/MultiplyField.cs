namespace Monopoly.DAL.Entities.GameEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class MultiplyField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int MultiplyMonopolyId { get; set; }
    }
}