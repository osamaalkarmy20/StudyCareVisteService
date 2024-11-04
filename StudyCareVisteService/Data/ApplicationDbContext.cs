
using Microsoft.EntityFrameworkCore;
using StudyCareVisteService.Model;
using StudyCareVisteService.ValueObjects;

namespace StudyCareVisteService.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<StudyCareVist> StudyCareVists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<StudyCareVist>(entity =>
            {
                entity.OwnsOne(y => y.BusinessOwner);
                entity.OwnsOne(y => y.CheckerRepresentative);
                entity.OwnsOne(y => y.ClassifySuccessStory);
                entity.OwnsOne(y => y.CollectionData);
                entity.OwnsOne(y => y.ConsultingService);
                entity.OwnsOne(y => y.CollectionEfforts);
                entity.OwnsOne(y => y.FinancialData);
                entity.OwnsOne(y => y.ObservedViolations);
                entity.OwnsOne(y => y.VisitExecutor);
            });
        }


    }
    }

