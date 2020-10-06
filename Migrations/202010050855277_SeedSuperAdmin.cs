namespace TeacherStudentConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSuperAdmin : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into SuperAdmins (SuperAdminId,Password) values ('Mahie-sp1','M@hie-sp1')");
        }
        
        public override void Down()
        {
        }
    }
}
