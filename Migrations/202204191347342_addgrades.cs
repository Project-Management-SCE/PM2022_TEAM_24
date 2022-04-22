namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgrades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradesModels", "Mygrade", c => c.String(nullable: false));
            AlterColumn("dbo.GradesModels", "Student_Name", c => c.String(nullable: false));
            DropColumn("dbo.GradesModels", "Grade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GradesModels", "Grade", c => c.Int(nullable: false));
            AlterColumn("dbo.GradesModels", "Student_Name", c => c.String());
            DropColumn("dbo.GradesModels", "Mygrade");
        }
    }
}
