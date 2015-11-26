namespace SafariBooks_Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChangePasswords", "Password_EmployeeID", c => c.String(maxLength: 128));
            CreateIndex("dbo.ChangePasswords", "Password_EmployeeID");
            AddForeignKey("dbo.ChangePasswords", "Password_EmployeeID", "dbo.Employees", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChangePasswords", "Password_EmployeeID", "dbo.Employees");
            DropIndex("dbo.ChangePasswords", new[] { "Password_EmployeeID" });
            DropColumn("dbo.ChangePasswords", "Password_EmployeeID");
        }
    }
}
