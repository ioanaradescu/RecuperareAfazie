namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PacientiVarstaOptionalCnpNumePrenumeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pacienti", "CNP", c => c.String(nullable: false));
            AlterColumn("dbo.Pacienti", "Nume", c => c.String(nullable: false));
            AlterColumn("dbo.Pacienti", "Prenume", c => c.String(nullable: false));
            AlterColumn("dbo.Pacienti", "Varsta", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pacienti", "Varsta", c => c.Int(nullable: false));
            AlterColumn("dbo.Pacienti", "Prenume", c => c.String());
            AlterColumn("dbo.Pacienti", "Nume", c => c.String());
            AlterColumn("dbo.Pacienti", "CNP", c => c.String());
        }
    }
}
