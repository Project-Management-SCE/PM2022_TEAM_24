namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudentGradesTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentGrades", "StudName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentGrades", "StudName");
        }
    }
}
