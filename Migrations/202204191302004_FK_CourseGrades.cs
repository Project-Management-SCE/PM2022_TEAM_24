namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_CourseGrades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradesModels", "CourseGrade_Id", c => c.Int());
            CreateIndex("dbo.GradesModels", "CourseGrade_Id");
            AddForeignKey("dbo.GradesModels", "CourseGrade_Id", "dbo.CourseModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GradesModels", "CourseGrade_Id", "dbo.CourseModels");
            DropIndex("dbo.GradesModels", new[] { "CourseGrade_Id" });
            DropColumn("dbo.GradesModels", "CourseGrade_Id");
        }
    }
}
