namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezultateSeparareTimpSiData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rezultate", "TimpRezolvare", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Rezultate", "DataRezolvare", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rezultate", "DataTimpRezolvare");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rezultate", "DataTimpRezolvare", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rezultate", "DataRezolvare");
            DropColumn("dbo.Rezultate", "TimpRezolvare");
        }
    }
}
