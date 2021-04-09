namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCC : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KhachHang", newName: "KhachHangs");
            CreateTable(
                "dbo.NhaCC",
                c => new
                    {
                        MaCC = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenCC = c.String(),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaCC);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHoaDon = c.String(),
                        NgayTao = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        MaHanghoa = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHangHoa = c.String(),
                        DonGia = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaHanghoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
            DropTable("dbo.HoaDons");
            DropTable("dbo.NhaCC");
            RenameTable(name: "dbo.KhachHangs", newName: "KhachHang");
        }
    }
}
