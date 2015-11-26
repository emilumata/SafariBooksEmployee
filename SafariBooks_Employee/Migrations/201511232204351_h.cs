namespace SafariBooks_Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class h : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Book_SKU", c => c.Int());
            AddColumn("dbo.Employees", "Employee_EmployeeID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Books", "Book_SKU");
            CreateIndex("dbo.Employees", "Employee_EmployeeID");
            AddForeignKey("dbo.Books", "Book_SKU", "dbo.Books", "SKU");
            AddForeignKey("dbo.Employees", "Employee_EmployeeID", "dbo.Employees", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Books", "Book_SKU", "dbo.Books");
            DropIndex("dbo.Employees", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.Books", new[] { "Book_SKU" });
            DropColumn("dbo.Employees", "Employee_EmployeeID");
            DropColumn("dbo.Books", "Book_SKU");
        }
    }
}
