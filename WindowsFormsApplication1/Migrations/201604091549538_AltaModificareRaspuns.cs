namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AltaModificareRaspuns : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Raspuns", newName: "Raspunsuri");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Raspunsuri", newName: "Raspuns");
        }
    }
}
