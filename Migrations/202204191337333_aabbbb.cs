namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aabbbb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GradesModels", "Grade", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GradesModels", "Grade", c => c.String(nullable: true));
        }
    }
}
