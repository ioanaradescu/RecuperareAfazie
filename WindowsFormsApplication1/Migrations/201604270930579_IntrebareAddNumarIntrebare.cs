namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntrebareAddNumarIntrebare : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Intrebari", "numarIntrebare", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Intrebari", "numarIntrebare");
        }
    }
}
