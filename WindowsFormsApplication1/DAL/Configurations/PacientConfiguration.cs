using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.DAL.Configurations
{
    public class PacientConfiguration : EntityTypeConfiguration<Pacient>
    {
        public PacientConfiguration()
        {
            ToTable("Pacienti");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CNP).IsRequired();
            Property(p => p.Nume).IsRequired();
            Property(p => p.Prenume).IsRequired();
        }

    }
}
