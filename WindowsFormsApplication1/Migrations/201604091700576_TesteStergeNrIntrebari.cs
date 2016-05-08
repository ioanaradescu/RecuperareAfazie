namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TesteStergeNrIntrebari : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teste", "Total_Intrebari");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teste", "Total_Intrebari", c => c.Int(nullable: false));
        }
    }
}
