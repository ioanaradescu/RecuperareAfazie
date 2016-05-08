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
    public class TestConfiguration: EntityTypeConfiguration<Test>
    {
        public TestConfiguration()
        {
            ToTable("Teste");

            HasKey(t => t.TestId);

            Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

    }
}
