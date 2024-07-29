using System;
using System.Collections.Generic;
using C_Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace C_Data_Access_Layer.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
        // test 
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
        //tap tanh
    }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giay> Giays { get; set; }

    public virtual DbSet<Giaychitiet> Giaychitiets { get; set; }

    public virtual DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Kieudang> Kieudangs { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Uudai> Uudais { get; set; }

    public virtual DbSet<GiayChiTietDTO> chiTietGiayDTOs { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-I6GJF6D7\\MSSQLSERVER03;Database=Du_An_Ban_Giay1;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F811299ABC");

            entity.ToTable("CHATLIEU");

            entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenchatlieu)
                .HasMaxLength(50)
                .HasColumnName("TENCHATLIEU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Chatlieus)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHATLIEU__MATAIK__38996AB5");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6AF910F3FD");

            entity.ToTable("CHUCVU");

            entity.Property(e => e.Machucvu)
                .ValueGeneratedNever()
                .HasColumnName("MACHUCVU");
            entity.Property(e => e.Tenchucvu)
                .HasMaxLength(50)
                .HasColumnName("TENCHUCVU");
        });

        modelBuilder.Entity<Giay>(entity =>
        {
            entity.HasKey(e => e.Magiay).HasName("PK__GIAY__0C880C58AEB59B84");

            entity.ToTable("GIAY");

            entity.Property(e => e.Magiay).HasColumnName("MAGIAY");
            entity.Property(e => e.Tengiay)
                .HasMaxLength(50)
                .HasColumnName("TENGIAY");
        });

        modelBuilder.Entity<Giaychitiet>(entity =>
        {
            entity.HasKey(e => e.Magiaychitiet).HasName("PK__GIAYCHIT__196AD7031BE6DBE5");

            entity.ToTable("GIAYCHITIET");

            entity.Property(e => e.Magiaychitiet).HasColumnName("MAGIAYCHITIET");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
            entity.Property(e => e.Magiay).HasColumnName("MAGIAY");
            entity.Property(e => e.Makichco).HasColumnName("MAKICHCO");
            entity.Property(e => e.Makieudang).HasColumnName("MAKIEUDANG");
            entity.Property(e => e.Mamausac).HasColumnName("MAMAUSAC");
            entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Ngaysua)
                .HasColumnType("date")
                .HasColumnName("NGAYSUA");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("date")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Machatlieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MACHA__47DBAE45");

            entity.HasOne(d => d.MagiayNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Magiay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MAGIA__45F365D3");

            entity.HasOne(d => d.MakichcoNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Makichco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MAKIC__4AB81AF0");

            entity.HasOne(d => d.MakieudangNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Makieudang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MAKIE__49C3F6B7");

            entity.HasOne(d => d.MamausacNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Mamausac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MAMAU__46E78A0C");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Mathuonghieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIAYCHITI__MATHU__48CFD27E");
        });

        modelBuilder.Entity<Hinhthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mahinhthucthanhtoan).HasName("PK__HINHTHUC__C3B2561FBD5DC538");

            entity.ToTable("HINHTHUCTHANHTOAN");

            entity.Property(e => e.Mahinhthucthanhtoan).HasColumnName("MAHINHTHUCTHANHTOAN");
            entity.Property(e => e.Tenhinhthuc)
                .HasMaxLength(50)
                .HasColumnName("TENHINHTHUC");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF5BFBB4B33");

            entity.ToTable("HOADON");

            entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(50)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Mahinhthucthanhtoan).HasColumnName("MAHINHTHUCTHANHTOAN");
            entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mauudai).HasColumnName("MAUUDAI");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("date")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MahinhthucthanhtoanNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mahinhthucthanhtoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAHINHTH__31EC6D26");

            entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makhachhang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAKHACHH__30F848ED");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MATAIKHO__300424B4");

            entity.HasOne(d => d.MauudaiNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mauudai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAUUDAI__32E0915F");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.Mahoadonchitiet).HasName("PK__HOADONCH__EF957FF0B4631B7E");

            entity.ToTable("HOADONCHITIET");

            entity.Property(e => e.Mahoadonchitiet).HasColumnName("MAHOADONCHITIET");
            entity.Property(e => e.Magiaychitiet).HasColumnName("MAGIAYCHITIET");
            entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
            entity.Property(e => e.Soluongmua).HasColumnName("SOLUONGMUA");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

            entity.HasOne(d => d.MagiaychitietNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Magiaychitiet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHI__MAGIA__4D94879B");

            entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Mahoadon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCHI__MAHOA__4E88ABD4");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2F58DA6320");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Diemkhachhang).HasColumnName("DIEMKHACHHANG");
            entity.Property(e => e.Sdt).HasColumnName("SDT");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(50)
                .HasColumnName("TENKHACHHANG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makichco).HasName("PK__KICHCO__7EDFFF290873E566");

            entity.ToTable("KICHCO");

            entity.Property(e => e.Makichco).HasColumnName("MAKICHCO");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenkichco)
                .HasMaxLength(50)
                .HasColumnName("TENKICHCO");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kichcos)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KICHCO__MATAIKHO__412EB0B6");
        });

        modelBuilder.Entity<Kieudang>(entity =>
        {
            entity.HasKey(e => e.Makieudang).HasName("PK__KIEUDANG__877F27F280CF3AC3");

            entity.ToTable("KIEUDANG");

            entity.Property(e => e.Makieudang).HasColumnName("MAKIEUDANG");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenkieudang)
                .HasMaxLength(50)
                .HasColumnName("TENKIEUDANG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kieudangs)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KIEUDANG__MATAIK__3E52440B");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamausac).HasName("PK__MAUSAC__99E7A68F207218C3");

            entity.ToTable("MAUSAC");

            entity.Property(e => e.Mamausac).HasColumnName("MAMAUSAC");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenmausac)
                .HasMaxLength(50)
                .HasColumnName("TENMAUSAC");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Mausacs)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MAUSAC__MATAIKHO__35BCFE0A");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Mataikhoan).HasName("PK__TAIKHOAN__2ED8B517106D70FC");

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("date")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Sdt).HasColumnName("SDT");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.Machucvu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__MACHUC__267ABA7A");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F638882F1410");

            entity.ToTable("THUONGHIEU");

            entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(50)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenthuonghieu)
                .HasMaxLength(50)
                .HasColumnName("TENTHUONGHIEU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Thuonghieus)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__THUONGHIE__MATAI__3B75D760");
        });

        modelBuilder.Entity<Uudai>(entity =>
        {
            entity.HasKey(e => e.Mauudai).HasName("PK__UUDAI__3F58B4FD3A6E2E5D");

            entity.ToTable("UUDAI");

            entity.Property(e => e.Mauudai).HasColumnName("MAUUDAI");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Ngaybatdau)
                .HasColumnType("datetime")
                .HasColumnName("NGAYBATDAU");
            entity.Property(e => e.Ngayketthuc)
                .HasColumnType("datetime")
                .HasColumnName("NGAYKETTHUC");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tenuudai)
                .HasMaxLength(50)
                .HasColumnName("TENUUDAI");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Uudais)
                .HasForeignKey(d => d.Mataikhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UUDAI__MATAIKHOA__2D27B809");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
