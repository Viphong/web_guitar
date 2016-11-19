namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DaydayDbContext : DbContext
    {
        public DaydayDbContext()
            : base("name=DaydayDbContext")
        {
        }

        public virtual DbSet<BaiGiang> BaiGiang { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<ChuDe> ChuDe { get; set; }
        public virtual DbSet<GiaiDieu> GiaiDieu { get; set; }
        public virtual DbSet<LoaiBaiGiang> LoaiBaiGiang { get; set; }
        public virtual DbSet<LoaiBlog> LoaiBlog { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhVien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaiGiang>()
                .HasMany(e => e.Video)
                .WithOptional(e => e.BaiGiang)
                .HasForeignKey(e => e.MaBG);

            modelBuilder.Entity<ChuDe>()
                .HasMany(e => e.BaiGiang)
                .WithOptional(e => e.ChuDe)
                .HasForeignKey(e => e.MaCD);

            modelBuilder.Entity<GiaiDieu>()
                .HasMany(e => e.BaiGiang)
                .WithOptional(e => e.GiaiDieu)
                .HasForeignKey(e => e.MaGD);

            modelBuilder.Entity<GiaiDieu>()
                .HasMany(e => e.Video)
                .WithOptional(e => e.GiaiDieu)
                .HasForeignKey(e => e.MaGD);

            modelBuilder.Entity<LoaiThanhVien>()
                .HasMany(e => e.ThanhVien)
                .WithOptional(e => e.LoaiThanhVien1)
                .HasForeignKey(e => e.LoaiThanhVien);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.Hinhanh)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Trangthai)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
