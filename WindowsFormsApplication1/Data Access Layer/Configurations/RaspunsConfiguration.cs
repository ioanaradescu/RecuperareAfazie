using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Data_Access_Layer.Configurations
{
    public class RaspunsConfiguration : EntityTypeConfiguration<Raspuns>
    {
        public RaspunsConfiguration()
        {
            ToTable("Raspunsuri");

            HasKey(r => r.RaspunsId);

            Property(r => r.RaspunsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(r => r.Rezultat) // FK Id_Rezultat : un rezultat are mai multe raspunsuri
                .WithMany(r => r.Raspunsuri)
                .HasForeignKey(r => r.RezultatId);
        }

    }
    
}
