namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Course_TEACHERcol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseModels", "Teacher_Course", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseModels", "Teacher_Course");
        }
    }
}
