namespace WebApiNetFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoDasTabelas : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imagems");
        }
    }
}
