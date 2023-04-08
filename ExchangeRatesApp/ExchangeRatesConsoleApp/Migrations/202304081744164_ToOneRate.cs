namespace ExchangeRatesConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToOneRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Currencies", "Rates_EffectiveDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Currencies", "Rates_Mid", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Currencies", "Rates_Mid");
            DropColumn("dbo.Currencies", "Rates_EffectiveDate");
        }
    }
}
