namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezultateTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rezultate", "TimpRezolvare", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezultate", "TimpRezolvare", c => c.Time(nullable: false, precision: 7));
        }
    }
}
