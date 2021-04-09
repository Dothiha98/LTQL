namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Demo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NhaCC", newName: "NhaCCs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.NhaCCs", newName: "NhaCC");
        }
    }
}
