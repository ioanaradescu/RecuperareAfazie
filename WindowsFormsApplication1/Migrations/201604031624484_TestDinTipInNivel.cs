namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestDinTipInNivel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teste", "Nivel", c => c.Int(nullable: false));
            DropColumn("dbo.Teste", "Tip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teste", "Tip", c => c.Int(nullable: false));
            DropColumn("dbo.Teste", "Nivel");
        }
    }
}
