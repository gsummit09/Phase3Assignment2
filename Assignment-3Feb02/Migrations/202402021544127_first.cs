namespace Assignment_3Feb02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BlogPosts", newName: "BlogPost");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.BlogPost", newName: "BlogPosts");
        }
    }
}
