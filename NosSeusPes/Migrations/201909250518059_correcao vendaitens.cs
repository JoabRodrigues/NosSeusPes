namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcaovendaitens : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sapatos", "VendaItem_Id", "dbo.VendaItens");
            DropIndex("dbo.Sapatos", new[] { "VendaItem_Id" });
            AddColumn("dbo.VendaItens", "Sapato_Id", c => c.Int());
            CreateIndex("dbo.VendaItens", "Sapato_Id");
            AddForeignKey("dbo.VendaItens", "Sapato_Id", "dbo.Sapatos", "Id");
            DropColumn("dbo.Sapatos", "VendaItem_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sapatos", "VendaItem_Id", c => c.Int());
            DropForeignKey("dbo.VendaItens", "Sapato_Id", "dbo.Sapatos");
            DropIndex("dbo.VendaItens", new[] { "Sapato_Id" });
            DropColumn("dbo.VendaItens", "Sapato_Id");
            CreateIndex("dbo.Sapatos", "VendaItem_Id");
            AddForeignKey("dbo.Sapatos", "VendaItem_Id", "dbo.VendaItens", "Id");
        }
    }
}
