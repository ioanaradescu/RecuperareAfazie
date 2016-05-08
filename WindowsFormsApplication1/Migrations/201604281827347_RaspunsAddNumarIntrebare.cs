namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaspunsAddNumarIntrebare : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Raspunsuri", "NumarIntrebare", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Raspunsuri", "NumarIntrebare");
        }
    }
}
