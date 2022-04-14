namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoursesTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseModels", "CourseDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseModels", "CourseDescription");
        }
    }
}
