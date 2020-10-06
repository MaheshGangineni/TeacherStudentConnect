namespace TeacherStudentConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        ContactNumber = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Subject = c.String(),
                        DateOfJoining = c.DateTime(),
                        PriorExperience = c.Int(),
                        Experience = c.Int(),
                        BatchNumber = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
