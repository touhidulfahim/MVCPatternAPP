namespace MVCPatternAPP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Category(CategoryName,Description) Values('Food and Beverage','Any kinds of food, drinks and others')");
            Sql("INSERT INTO Category(CategoryName,Description) Values('Cloth','Male, Female Cloth')");
            Sql("INSERT INTO Category(CategoryName,Description) Values('Healthcare','healthcare products')");
            Sql("INSERT INTO Category(CategoryName,Description) Values('Telecommunication & Computing','telecommunication & computing item')");
            Sql("INSERT INTO Category(CategoryName,Description) Values('Pharmaceuticals','human, animal drug')");
        }
        
        public override void Down()
        {

        }
    }
}
