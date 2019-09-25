namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvendaitens : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VendaSapatoes", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.VendaSapatoes", "Sapato_Id", "dbo.Sapatos");
            DropIndex("dbo.VendaSapatoes", new[] { "Venda_Id" });
            DropIndex("dbo.VendaSapatoes", new[] { "Sapato_Id" });
            CreateTable(
                "dbo.VendaItens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        Venda_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vendas", t => t.Venda_Id)
                .Index(t => t.Venda_Id);
            
            AddColumn("dbo.Sapatos", "VendaItem_Id", c => c.Int());
            AddColumn("dbo.Vendas", "Sapato_Id", c => c.Int());
            CreateIndex("dbo.Sapatos", "VendaItem_Id");
            CreateIndex("dbo.Vendas", "Sapato_Id");
            AddForeignKey("dbo.Sapatos", "VendaItem_Id", "dbo.VendaItens", "Id");
            AddForeignKey("dbo.Vendas", "Sapato_Id", "dbo.Sapatos", "Id");
            DropColumn("dbo.Vendas", "Preco");
            DropColumn("dbo.Vendas", "Quantidade");
            DropTable("dbo.VendaSapatoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VendaSapatoes",
                c => new
                    {
                        Venda_Id = c.Int(nullable: false),
                        Sapato_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Venda_Id, t.Sapato_Id });
            
            AddColumn("dbo.Vendas", "Quantidade", c => c.Int(nullable: false));
            AddColumn("dbo.Vendas", "Preco", c => c.Double(nullable: false));
            DropForeignKey("dbo.Vendas", "Sapato_Id", "dbo.Sapatos");
            DropForeignKey("dbo.VendaItens", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.Sapatos", "VendaItem_Id", "dbo.VendaItens");
            DropIndex("dbo.VendaItens", new[] { "Venda_Id" });
            DropIndex("dbo.Vendas", new[] { "Sapato_Id" });
            DropIndex("dbo.Sapatos", new[] { "VendaItem_Id" });
            DropColumn("dbo.Vendas", "Sapato_Id");
            DropColumn("dbo.Sapatos", "VendaItem_Id");
            DropTable("dbo.VendaItens");
            CreateIndex("dbo.VendaSapatoes", "Sapato_Id");
            CreateIndex("dbo.VendaSapatoes", "Venda_Id");
            AddForeignKey("dbo.VendaSapatoes", "Sapato_Id", "dbo.Sapatos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VendaSapatoes", "Venda_Id", "dbo.Vendas", "Id", cascadeDelete: true);
        }
    }
}
