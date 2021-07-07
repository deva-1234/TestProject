namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "customer_Id", "dbo.Customers");
            DropIndex("dbo.Addresses", new[] { "customer_Id" });
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Addresses", "customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "customer_Id", c => c.Int());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            CreateIndex("dbo.Addresses", "customer_Id");
            AddForeignKey("dbo.Addresses", "customer_Id", "dbo.Customers", "Id");
        }
    }
}
