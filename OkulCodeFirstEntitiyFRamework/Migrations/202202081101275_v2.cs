namespace OkulCodeFirstEntitiyFRamework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Instructors", "FirstName");
            CreateIndex("dbo.Students", "FirstName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "FirstName" });
            DropIndex("dbo.Instructors", new[] { "FirstName" });
        }
    }
}
