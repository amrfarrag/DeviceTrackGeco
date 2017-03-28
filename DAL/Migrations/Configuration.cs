namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DeviceTractingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.DeviceTractingContext context)
        {
            Model.EmployerTitle tit = new Model.EmployerTitle() { Title = "Eng" };
            context.EmployerTitles.Add(tit);
            context.SaveChanges();
        }
    }
}
