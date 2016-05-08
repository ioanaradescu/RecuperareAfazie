namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApplication1.Data_Access_Layer.RecuperareAfazieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WindowsFormsApplication1.Data_Access_Layer.RecuperareAfazieContext context)
        {

        }
    }
}
