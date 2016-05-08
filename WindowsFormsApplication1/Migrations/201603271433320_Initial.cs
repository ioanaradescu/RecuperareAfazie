namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Intrebari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(nullable: false),
                        TextIntrebare = c.String(),
                        Raspuns1 = c.String(),
                        Raspuns2 = c.String(),
                        Raspuns3 = c.String(),
                        Raspuns4 = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teste", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Teste",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Tip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestId);
            
            CreateTable(
                "dbo.Pacienti",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNP = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Varsta = c.Int(nullable: false),
                        Observatii = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Intrebari", "TestId", "dbo.Teste");
            DropIndex("dbo.Intrebari", new[] { "TestId" });
            DropTable("dbo.Pacienti");
            DropTable("dbo.Teste");
            DropTable("dbo.Intrebari");
        }
    }
}
