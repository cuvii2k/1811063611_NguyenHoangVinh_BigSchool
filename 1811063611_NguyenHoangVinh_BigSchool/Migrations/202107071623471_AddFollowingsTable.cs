namespace _1811063611_NguyenHoangVinh_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "LecturerID" });
            CreateIndex("dbo.Courses", "LecturerId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            CreateIndex("dbo.Courses", "LecturerID");
        }
    }
}
