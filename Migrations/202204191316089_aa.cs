namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.GradesModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GradesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grade = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
