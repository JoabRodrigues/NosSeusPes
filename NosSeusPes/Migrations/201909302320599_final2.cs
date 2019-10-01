namespace NosSeusPes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cores", "Nome", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Sapatos", "Nome", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Marcas", "Nome", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
            AlterColumn("dbo.Marcas", "Nome", c => c.String());
            AlterColumn("dbo.Sapatos", "Nome", c => c.String());
            AlterColumn("dbo.Cores", "Nome", c => c.String());
        }
    }
}
