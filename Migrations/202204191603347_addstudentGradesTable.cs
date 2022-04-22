namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudentGradesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MyGrade = c.String(),
                        My_Course = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentGrades");
        }
    }
}
