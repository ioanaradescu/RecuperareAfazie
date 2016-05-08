namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezultateTimeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rezultate", "TimpRezolvare", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezultate", "TimpRezolvare", c => c.String());
        }
    }
}
