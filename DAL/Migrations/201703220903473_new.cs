namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployerDevices", "EmployerDeviceDescriptionID", "dbo.EmployerDeviceDescriptions");
            DropForeignKey("dbo.EmployerDevices", "EmployerID", "dbo.Employers");
            DropForeignKey("dbo.EmployerDevices", "ProjectID", "dbo.Projects");
            DropIndex("dbo.EmployerDevices", new[] { "EmployerDeviceDescriptionID" });
            DropIndex("dbo.EmployerDevices", new[] { "EmployerID" });
            DropIndex("dbo.EmployerDevices", new[] { "ProjectID" });
            DropTable("dbo.Devices");
            DropTable("dbo.EmployerDeviceDescriptions");
            DropTable("dbo.EmployerDevices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployerDevices",
                c => new
                    {
                        EmployerDeviceID = c.Int(nullable: false, identity: true),
                        EmployerID = c.Int(nullable: false),
                        ProjectID = c.Int(nullable: false),
                        EmployerDeviceDescriptionID = c.Int(nullable: false),
                        IsOwned = c.Boolean(nullable: false),
                        AssignedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployerDeviceID);
            
            CreateTable(
                "dbo.EmployerDeviceDescriptions",
                c => new
                    {
                        EmployerDeviceDescriptionID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.EmployerDeviceDescriptionID);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Owenr = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.EmployerDevices", "ProjectID");
            CreateIndex("dbo.EmployerDevices", "EmployerID");
            CreateIndex("dbo.EmployerDevices", "EmployerDeviceDescriptionID");
            AddForeignKey("dbo.EmployerDevices", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
            AddForeignKey("dbo.EmployerDevices", "EmployerID", "dbo.Employers", "EmployerID", cascadeDelete: true);
            AddForeignKey("dbo.EmployerDevices", "EmployerDeviceDescriptionID", "dbo.EmployerDeviceDescriptions", "EmployerDeviceDescriptionID", cascadeDelete: true);
        }
    }
}
