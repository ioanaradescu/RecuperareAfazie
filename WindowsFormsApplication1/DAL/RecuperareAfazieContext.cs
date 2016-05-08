using System.Data.Entity;
using WindowsFormsApplication1.DAL.Configurations;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.DAL
{
    public class RecuperareAfazieContext : DbContext
    {
        public RecuperareAfazieContext() : base("RecuperareAfazie")
        {
        }

        public virtual DbSet<Pacient> Pacienti { get; set; }
        public virtual DbSet<Test> Teste { get; set; }
        public virtual DbSet<Intrebare> Intrebari { get; set; }
        public virtual DbSet<Rezultat> Rezultate { get; set; }
        public virtual DbSet<Raspuns> Raspunsuri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new IntrebareConfiguration());
            modelBuilder.Configurations.Add(new PacientConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new RezultatConfiguration());
            modelBuilder.Configurations.Add(new RaspunsConfiguration());
        }
    }
}
