namespace WebApiNetFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imagems",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Caminho = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        CPF = c.String(),
                        RG = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Imagems");
        }
    }
}
