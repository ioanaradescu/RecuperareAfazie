using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.DAL.Configurations
{
    public class IntrebareConfiguration : EntityTypeConfiguration<Intrebare>
    {
        public IntrebareConfiguration()
        {
            ToTable("Intrebari");

            HasKey(i => i.Id);

            Property(i => i.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(i => i.Test)
                .WithMany(t => t.Intrebari)
                .HasForeignKey(i => i.TestId);

        }
    }
}
