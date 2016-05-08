namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RezultateSiRaspunsuriAdaugare : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rezultate",
                c => new
                    {
                        RezultatId = c.Int(nullable: false, identity: true),
                        PacientId = c.Int(nullable: false),
                        TestId = c.Int(nullable: false),
                        RaspunsuriCorecte = c.Int(),
                        RaspunsuriGresite = c.Int(),
                        DataTimpRezolvare = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RezultatId)
                .ForeignKey("dbo.Pacienti", t => t.PacientId, cascadeDelete: true)
                .ForeignKey("dbo.Teste", t => t.TestId, cascadeDelete: true)
                .Index(t => t.PacientId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Raspuns",
                c => new
                    {
                        RaspunsId = c.Int(nullable: false, identity: true),
                        RezultatId = c.Int(nullable: false),
                        RaspunsCorect = c.String(),
                        RaspunsGresit = c.String(),
                    })
                .PrimaryKey(t => t.RaspunsId)
                .ForeignKey("dbo.Rezultate", t => t.RezultatId, cascadeDelete: true)
                .Index(t => t.RezultatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezultate", "TestId", "dbo.Teste");
            DropForeignKey("dbo.Raspuns", "RezultatId", "dbo.Rezultate");
            DropForeignKey("dbo.Rezultate", "PacientId", "dbo.Pacienti");
            DropIndex("dbo.Raspuns", new[] { "RezultatId" });
            DropIndex("dbo.Rezultate", new[] { "TestId" });
            DropIndex("dbo.Rezultate", new[] { "PacientId" });
            DropTable("dbo.Raspuns");
            DropTable("dbo.Rezultate");
        }
    }
}
