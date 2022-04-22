namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aabb : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.GradesModels");
        }
    }
}
