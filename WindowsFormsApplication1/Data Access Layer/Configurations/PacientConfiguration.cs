using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1.Data_Access_Layer.Configurations
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
