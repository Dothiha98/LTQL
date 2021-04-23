using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<KhachHang> Khachhangs { get; set; }

        public virtual DbSet<NhaCC> NhaCCs { get; set; }

        public virtual DbSet<HoaDon> HoaDons { get; set; }

        public virtual DbSet<HangHoa> HangHoas { get; set; }

    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaCC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
               .Property(e => e.NgayTao)
               .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
               .Property(e => e.DonGia)
               .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHanghoa)
                .IsUnicode(false);


        } 
    }
}
