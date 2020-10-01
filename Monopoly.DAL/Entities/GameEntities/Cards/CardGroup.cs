namespace Monopoly.DAL.Entities.GameEntities.Cards
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class CardGroup : BaseEntity
    {
        public string DefaultName { get; set; }

        public string Title { get; set; }
    }
}