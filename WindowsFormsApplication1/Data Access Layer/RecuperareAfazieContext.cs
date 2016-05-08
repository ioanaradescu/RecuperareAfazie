using System.Data.Entity;
using WindowsFormsApplication1.Data_Access_Layer.Configurations;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Data_Access_Layer
{
    public class RecuperareAfazieContext : DbContext
    {
        public RecuperareAfazieContext() : base("RecuperareAfazie")
        {

        }

        public DbSet<Pacient> Pacienti { get; set; }
        public DbSet<Test> Teste { get; set; }
        public DbSet<Intrebare> Intrebari { get; set; }
        public DbSet<Rezultat> Rezultate { get; set; }
        public DbSet<Raspuns> Raspunsuri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new IntrebareConfiguration());
            modelBuilder.Configurations.Add(new PacientConfiguration());
            modelBuilder.Configurations.Add(new TestConfiguration());
            modelBuilder.Configurations.Add(new RezultatConfiguration());
            modelBuilder.Configurations.Add(new RaspunsConfiguration());        }

    }
}
