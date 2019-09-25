namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Modelos", "marcaId", "dbo.Marcas");
            DropForeignKey("dbo.Sapatos", "modeloId", "dbo.Modelos");
            DropForeignKey("dbo.Sapatos", "corId", "dbo.Cores");
            DropIndex("dbo.Sapatos", new[] { "corId" });
            DropIndex("dbo.Sapatos", new[] { "modeloId" });
            DropIndex("dbo.Modelos", new[] { "marcaId" });
            RenameColumn(table: "dbo.Sapatos", name: "corId", newName: "Cor_Id");
            AddColumn("dbo.Sapatos", "PresencaDeCardarco", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sapatos", "Marca_Id", c => c.Int());
            AlterColumn("dbo.Sapatos", "Cor_Id", c => c.Int());
            CreateIndex("dbo.Sapatos", "Cor_Id");
            CreateIndex("dbo.Sapatos", "Marca_Id");
            AddForeignKey("dbo.Sapatos", "Marca_Id", "dbo.Marcas", "Id");
            AddForeignKey("dbo.Sapatos", "Cor_Id", "dbo.Cores", "Id");
            DropColumn("dbo.Sapatos", "modeloId");
            DropTable("dbo.Modelos");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sapatos", "modeloId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sapatos", "Cor_Id", "dbo.Cores");
            DropForeignKey("dbo.Sapatos", "Marca_Id", "dbo.Marcas");
            DropIndex("dbo.Sapatos", new[] { "Marca_Id" });
            DropIndex("dbo.Sapatos", new[] { "Cor_Id" });
            AlterColumn("dbo.Sapatos", "Cor_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Sapatos", "Marca_Id");
            DropColumn("dbo.Sapatos", "PresencaDeCardarco");
            RenameColumn(table: "dbo.Sapatos", name: "Cor_Id", newName: "corId");
            CreateIndex("dbo.Modelos", "marcaId");
            CreateIndex("dbo.Sapatos", "modeloId");
            CreateIndex("dbo.Sapatos", "corId");
            AddForeignKey("dbo.Sapatos", "corId", "dbo.Cores", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sapatos", "modeloId", "dbo.Modelos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Modelos", "marcaId", "dbo.Marcas", "Id", cascadeDelete: true);
        }
    }
}
