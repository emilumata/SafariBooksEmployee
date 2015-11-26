namespace SafariBooks_Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChangePasswords",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        OldPassword = c.String(nullable: false, maxLength: 255),
                        NewPassword = c.String(nullable: false, maxLength: 255),
                        ConfirmNewPassword = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChangePasswords");
        }
    }
}
