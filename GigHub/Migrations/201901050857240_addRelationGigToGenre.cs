namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationGigToGenre : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Gigs", "GenreId");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Gigs", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Genre", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "GenreId" });
        }
    }
}
