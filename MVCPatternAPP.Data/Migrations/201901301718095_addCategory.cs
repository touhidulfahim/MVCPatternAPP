namespace MVCPatternAPP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
           
        }
        
        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
