namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aabbjjj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradesModels", "Student_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GradesModels", "Student_Name");
        }
    }
}
