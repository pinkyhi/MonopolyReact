namespace Monopoly.DAL
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Monopoly.DAL.Entities;
    using Monopoly.DAL.Entities.JoinEntities;

    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("DESIGN", "Nix02:Method is too long", Justification = "<FluentAPI>")]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Game M:M User
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Membership>()
                .HasIndex(m => new { m.GameId, m.UserId })
                .IsUnique();
            modelBuilder.Entity<Game>()
                .HasMany(g => g.Membership)
                .WithOne(m => m.Game)
                .HasForeignKey(m => m.GameId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Membership)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId);

            // CityCardsIndexes
            modelBuilder.Entity<CityCard>()
                .HasIndex(m => new { m.CityId, m.CardId })
                .IsUnique();
            modelBuilder.Entity<CityEventField>()
                .HasIndex(m => new { m.CityId, m.EventFieldId })
                .IsUnique();
            modelBuilder.Entity<CityMovementField>()
                .HasIndex(m => new { m.CityId, m.MovementFieldId })
                .IsUnique();
            modelBuilder.Entity<CityMultiplyField>()
               .HasIndex(m => new { m.CityId, m.MultiplyFieldId })
                .IsUnique();
            modelBuilder.Entity<CityStreet>()
                .HasIndex(m => new { m.CityId, m.StreetId })
                .IsUnique();

            // GameCardsKeys
            modelBuilder.Entity<GameCard>()
                .HasKey(e => new { e.CardId, e.GameId });
            modelBuilder.Entity<GameEventField>()
                .HasKey(e => new { e.EventFieldId, e.GameId });
            modelBuilder.Entity<GameMovementField>()
                .HasKey(e => new { e.MovementFieldId, e.GameId });
            modelBuilder.Entity<GameMultiplyField>()
                .HasKey(e => new { e.MultiplyFieldId, e.GameId });
            modelBuilder.Entity<GameStreet>()
                .HasKey(e => new { e.StreetId, e.GameId });

            // Game 1:1 Settings
            modelBuilder.Entity<Game>()
                .HasOne(g => g.GameSettings)
                .WithOne(s => s.Game)
                .HasForeignKey<Game>(g => g.SettingsId)
                .OnDelete(DeleteBehavior.Cascade);

            // GameFields M:1 Owner
            modelBuilder.Entity<GameMovementField>()
                .HasOne(mf => mf.Owner)
                .WithMany(g => g.MovementFields)
                .HasForeignKey(mf => mf.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<GameCard>()
                .HasOne(c => c.Owner)
                .WithMany(g => g.Cards)
                .HasForeignKey(c => c.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<GameEventField>()
                .HasOne(ef => ef.Owner)
                .WithMany(g => g.EventFields)
                .HasForeignKey(ef => ef.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<GameMultiplyField>()
                .HasOne(mf => mf.Owner)
                .WithMany(g => g.MultiplyFields)
                .HasForeignKey(mf => mf.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<GameStreet>()
                .HasOne(s => s.Owner)
                .WithMany(g => g.Streets)
                .HasForeignKey(s => s.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            // GameFields M:1 Games
            modelBuilder.Entity<GameMovementField>()
                .HasOne(mf => mf.Game)
                .WithMany(g => g.MovementFields)
                .HasForeignKey(mf => mf.GameId)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<GameCard>()
                .HasOne(c => c.Game)
                .WithMany(g => g.Cards)
                .HasForeignKey(c => c.GameId)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<GameEventField>()
                .HasOne(ef => ef.Game)
                .WithMany(g => g.EventFields)
                .HasForeignKey(ef => ef.GameId)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<GameMultiplyField>()
                .HasOne(mf => mf.Game)
                .WithMany(g => g.MultiplyFields)
                .HasForeignKey(mf => mf.GameId)
                .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<GameStreet>()
                .HasOne(s => s.Game)
                .WithMany(g => g.Streets)
                .HasForeignKey(s => s.GameId)
                .OnDelete(DeleteBehavior.ClientCascade);

            // City M:M Field
            modelBuilder.Entity<CityCard>()
                .HasOne(e => e.EventCard)
                .WithMany(e => e.CityCards)
                .HasForeignKey(e => e.CardId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityEventField>()
                .HasOne(e => e.EventField)
                .WithMany(e => e.CityEventFields)
                .HasForeignKey(e => e.EventFieldId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityMovementField>()
                .HasOne(e => e.MovementField)
                .WithMany(e => e.CityMovementFields)
                .HasForeignKey(e => e.MovementFieldId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityMultiplyField>()
                .HasOne(e => e.MultiplyField)
                .WithMany(e => e.CityMultiplyFields)
                .HasForeignKey(e => e.MultiplyFieldId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityStreet>()
                .HasOne(e => e.Street)
                .WithMany(e => e.CityStreets)
                .HasForeignKey(e => e.StreetId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CityCard>()
                .HasOne(e => e.City)
                .WithMany(e => e.CityCards)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityEventField>()
                .HasOne(e => e.City)
                .WithMany(e => e.CityEventFields)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityMovementField>()
                .HasOne(e => e.City)
                .WithMany(e => e.CityMovementFields)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityMultiplyField>()
                .HasOne(e => e.City)
                .WithMany(e => e.CityMultiplyFields)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CityStreet>()
                .HasOne(e => e.City)
                .WithMany(e => e.CityStreets)
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            // CityCards 1:M GameCards
            modelBuilder.Entity<CityCard>()
                .HasMany(e => e.GameCards)
                .WithOne(e => e.Card)
                .HasForeignKey(e => e.CardId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CityEventField>()
                .HasMany(e => e.GameEventFields)
                .WithOne(e => e.EventField)
                .HasForeignKey(e => e.EventFieldId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CityMovementField>()
                .HasMany(e => e.GameMovementFields)
                .WithOne(e => e.MovementField)
                .HasForeignKey(e => e.MovementFieldId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CityMultiplyField>()
                .HasMany(e => e.GameMultiplyFields)
                .WithOne(e => e.MultiplyField)
                .HasForeignKey(e => e.MultiplyFieldId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CityStreet>()
                .HasMany(e => e.GameStreets)
                .WithOne(e => e.Street)
                .HasForeignKey(e => e.StreetId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}