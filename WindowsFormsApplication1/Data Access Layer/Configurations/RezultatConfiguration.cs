using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Data_Access_Layer.Configurations
{
    public class RezultatConfiguration: EntityTypeConfiguration<Rezultat>
    {
        public RezultatConfiguration()
        {
            ToTable("Rezultate");

            HasKey(r => r.RezultatId);

            Property(r => r.RezultatId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(r => r.Test)   // FK IdTest
                .WithMany(t => t.Rezultate)
                .HasForeignKey(r => r.TestId);

            HasRequired(r => r.Pacient) // FK IdPacient
                .WithMany(p => p.Rezultate)
                .HasForeignKey(r => r.PacientId);

            Property(r => r.TimpRezolvare).IsRequired();

        }

        

    }
}
