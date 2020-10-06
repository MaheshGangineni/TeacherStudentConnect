namespace TeacherStudentConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSuperAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperAdmins",
                c => new
                    {
                        SuperAdminId = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SuperAdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SuperAdmins");
        }
    }
}
