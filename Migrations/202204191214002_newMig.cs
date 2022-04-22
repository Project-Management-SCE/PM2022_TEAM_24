namespace IdintityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserViewModels");
        }
    }
}
