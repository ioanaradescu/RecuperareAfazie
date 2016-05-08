namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaspunsModificare : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Raspuns", "RaspunsDat", c => c.String());
            DropColumn("dbo.Raspuns", "RaspunsGresit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Raspuns", "RaspunsGresit", c => c.String());
            DropColumn("dbo.Raspuns", "RaspunsDat");
        }
    }
}
