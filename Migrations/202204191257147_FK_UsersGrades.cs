namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK_UsersGrades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GradesModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Grade = c.String(nullable: false),
                        student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserViewModels", t => t.student_Id)
                .Index(t => t.student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GradesModels", "student_Id", "dbo.UserViewModels");
            DropIndex("dbo.GradesModels", new[] { "student_Id" });
            DropTable("dbo.GradesModels");
        }
    }
}
