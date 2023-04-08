namespace ExchangeRatesConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyCode = c.String(nullable: false, maxLength: 128),
                        CurrencyName = c.String(),
                    })
                .PrimaryKey(t => t.CurrencyCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Currencies");
        }
    }
}
