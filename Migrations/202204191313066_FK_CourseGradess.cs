namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_CourseGradess : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GradesModels", "CourseGrade_Id", "dbo.CourseModels");
            DropForeignKey("dbo.GradesModels", "student_Id", "dbo.UserViewModels");
            DropIndex("dbo.GradesModels", new[] { "CourseGrade_Id" });
            DropIndex("dbo.GradesModels", new[] { "student_Id" });
            DropColumn("dbo.GradesModels", "CourseGrade_Id");
            DropColumn("dbo.GradesModels", "student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GradesModels", "student_Id", c => c.Int());
            AddColumn("dbo.GradesModels", "CourseGrade_Id", c => c.Int());
            CreateIndex("dbo.GradesModels", "student_Id");
            CreateIndex("dbo.GradesModels", "CourseGrade_Id");
            AddForeignKey("dbo.GradesModels", "student_Id", "dbo.UserViewModels", "Id");
            AddForeignKey("dbo.GradesModels", "CourseGrade_Id", "dbo.CourseModels", "Id");
        }
    }
}
