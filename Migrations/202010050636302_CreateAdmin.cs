namespace TeacherStudentConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        ContactNumber = c.Long(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        AdminProfileStatus = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
