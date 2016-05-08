namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestAdaugareNrIntrebari : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teste", "Total_Intrebari", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teste", "Total_Intrebari");
        }
    }
}
