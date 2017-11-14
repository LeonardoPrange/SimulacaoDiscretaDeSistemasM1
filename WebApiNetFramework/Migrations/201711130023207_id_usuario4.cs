namespace WebApiNetFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id_usuario4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Usuarios", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Usuarios");
            AlterColumn("dbo.Usuarios", "ID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Usuarios", "ID");
        }
    }
}
