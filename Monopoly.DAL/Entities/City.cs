namespace Monopoly.DAL.Entities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class City : BaseEntity
    {
        public string Name { get; set; }

        public int AuthorId { get; set; }
    }
}