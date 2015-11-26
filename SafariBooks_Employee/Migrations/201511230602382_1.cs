namespace SafariBooks_Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ConfirmPassword", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "ConfirmPassword");
        }
    }
}
