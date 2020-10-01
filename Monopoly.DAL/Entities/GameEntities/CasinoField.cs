namespace Monopoly.DAL.Entities.GameEntities
{
    using Monopoly.DAL.Entities.BaseEntities;

    public class CasinoField : BaseEntity
    {
        public string DefaultName { get; set; }

        public int CasinoType { get; set; }

        public int Balance { get; set; }
    }
}