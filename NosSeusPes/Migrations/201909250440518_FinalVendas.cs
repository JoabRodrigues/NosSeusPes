namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalVendas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendas", "ValorTotal", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendas", "ValorTotal");
        }
    }
}
