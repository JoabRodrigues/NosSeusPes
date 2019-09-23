namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sapatos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        tamanho = c.Int(nullable: false),
                        quantidade = c.Int(nullable: false),
                        corId = c.Int(nullable: false),
                        modeloId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cores", t => t.corId, cascadeDelete: true)
                .ForeignKey("dbo.Modelos", t => t.modeloId, cascadeDelete: true)
                .Index(t => t.corId)
                .Index(t => t.modeloId);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        PresencaDeCardarco = c.Boolean(nullable: false),
                        CadarcoSN = c.Int(nullable: false),
                        Material = c.String(),
                        materialId = c.Int(nullable: false),
                        marcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.marcaId, cascadeDelete: true)
                .Index(t => t.marcaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Preco = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        CPF = c.String(),
                        DataNascimento = c.DateTime(),
                        CNPJ = c.String(),
                        RazaoSocial = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VendaSapatoes",
                c => new
                    {
                        Venda_Id = c.Int(nullable: false),
                        Sapato_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Venda_Id, t.Sapato_Id })
                .ForeignKey("dbo.Vendas", t => t.Venda_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sapatos", t => t.Sapato_Id, cascadeDelete: true)
                .Index(t => t.Venda_Id)
                .Index(t => t.Sapato_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendaSapatoes", "Sapato_Id", "dbo.Sapatos");
            DropForeignKey("dbo.VendaSapatoes", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Pessoas");
            DropForeignKey("dbo.Sapatos", "modeloId", "dbo.Modelos");
            DropForeignKey("dbo.Modelos", "marcaId", "dbo.Marcas");
            DropForeignKey("dbo.Sapatos", "corId", "dbo.Cores");
            DropIndex("dbo.VendaSapatoes", new[] { "Sapato_Id" });
            DropIndex("dbo.VendaSapatoes", new[] { "Venda_Id" });
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            DropIndex("dbo.Modelos", new[] { "marcaId" });
            DropIndex("dbo.Sapatos", new[] { "modeloId" });
            DropIndex("dbo.Sapatos", new[] { "corId" });
            DropTable("dbo.VendaSapatoes");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Vendas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Modelos");
            DropTable("dbo.Sapatos");
            DropTable("dbo.Cores");
        }
    }
}
