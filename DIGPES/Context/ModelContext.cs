namespace DIGPES.Context
{
    using DIGPES.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
    }
}