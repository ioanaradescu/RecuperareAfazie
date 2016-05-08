namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntrebareStergeNrIntrebare : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Intrebari", "numarIntrebare");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Intrebari", "numarIntrebare", c => c.String(nullable: false));
        }
    }
}
