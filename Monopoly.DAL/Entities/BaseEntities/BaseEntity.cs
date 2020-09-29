namespace Monopoly.DAL.Entities.BaseEntities
{
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseEntity : BaseDto
    {
        [Key]
        public int Id { get; set; }
    }
}