namespace SafariBooks_Employee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        SKU = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorFirst = c.String(),
                        AuthorLast = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SKU);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
