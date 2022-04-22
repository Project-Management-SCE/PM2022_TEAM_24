namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgrades2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradesModels", "Course_Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GradesModels", "Course_Name");
        }
    }
}
