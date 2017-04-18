namespace MyBlogService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialPostUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        NumberOfPosts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
        }
    }
}
