namespace eCollegeApp.Generic.EntityProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educator",
                c => new
                    {
                        EducatorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false, maxLength: 10),
                        DOB = c.DateTime(nullable: false),
                        EducatorKey = c.String(),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 20),
                        Zip = c.String(maxLength: 10),
                        Email = c.String(),
                        Phone = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EducatorId);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        ProfileId = c.Int(nullable: false),
                        ProfileImage = c.Binary(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProfileId)
                .ForeignKey("dbo.Student", t => t.ProfileId)
                .ForeignKey("dbo.Educator", t => t.ProfileId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 100),
                        FathersName = c.String(nullable: false, maxLength: 100),
                        MothersName = c.String(nullable: false, maxLength: 100),
                        GuardianName = c.String(maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        DOB = c.DateTime(nullable: false),
                        RegdNumber = c.String(nullable: false),
                        Street = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        State = c.String(maxLength: 20),
                        Zip = c.String(maxLength: 10),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profile", "ProfileId", "dbo.Educator");
            DropForeignKey("dbo.Profile", "ProfileId", "dbo.Student");
            DropIndex("dbo.Profile", new[] { "ProfileId" });
            DropTable("dbo.Student");
            DropTable("dbo.Profile");
            DropTable("dbo.Educator");
        }
    }
}
