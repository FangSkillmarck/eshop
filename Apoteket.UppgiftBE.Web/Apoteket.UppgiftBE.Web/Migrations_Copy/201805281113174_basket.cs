namespace Apoteket.UppgiftBE.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class basket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(),
                        NumberOfOrder = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Baskets");
        }
    }
}
