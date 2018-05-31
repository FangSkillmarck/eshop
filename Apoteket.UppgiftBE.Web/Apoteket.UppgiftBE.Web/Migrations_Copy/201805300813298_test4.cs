namespace Apoteket.UppgiftBE.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Baskets", "NumberOfOrder", c => c.Int());
            DropColumn("dbo.Baskets", "OrderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Baskets", "OrderName", c => c.Int());
            DropColumn("dbo.Baskets", "NumberOfOrder");
        }
    }
}
