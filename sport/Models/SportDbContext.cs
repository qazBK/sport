using Microsoft.EntityFrameworkCore;

namespace sport.Models;

public partial class SportDbContext : DbContext
{
    public SportDbContext()
    {
    }

    public SportDbContext(DbContextOptions<SportDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<Point> Points { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCatigory> ProductCatigories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sport_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_manufacturers_id");

            entity.ToTable("manufacturers");

            entity.HasIndex(e => e.ManufacturerName, "uk_manufacturer_name_manufacturers").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManufacturerName).HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_orders_id");

            entity.ToTable("orders");

            entity.HasIndex(e => e.ReceiptCode, "uq_orders_receipt_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.IdOrderStatus).HasColumnName("id_order_status");
            entity.Property(e => e.IdPoint).HasColumnName("id_point");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.ReceiptCode).HasColumnName("receipt_code");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdOrderStatus)
                .HasConstraintName("fk_orders_to_order_statuses");

            entity.HasOne(d => d.Point).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdPoint)
                .HasConstraintName("fk_orders_to_points");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_orders_to_users");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_order_products_id");

            entity.ToTable("order_products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("fk_order_products_to_orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("fk_order_products_to_product");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_order_statuses_id");

            entity.ToTable("order_statuses");

            entity.HasIndex(e => e.OrderStatuses, "uk_order_status_name_order_statuses").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderStatuses).HasColumnName("order_statuses");
        });

        modelBuilder.Entity<Point>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_points_id");

            entity.ToTable("points");

            entity.HasIndex(e => e.Number, "uk_number_points").IsUnique();

            entity.HasIndex(e => e.PointAdres, "uk_point_adres_points").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.PointAdres).HasColumnName("point_adres");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_products_id");

            entity.ToTable("products");

            entity.HasIndex(e => e.Article, "uk_article_products").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdProductCatigori).HasColumnName("id_product_catigori");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdUnit).HasColumnName("id_unit");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Praise).HasColumnName("praise");
            entity.Property(e => e.ProductName).HasColumnName("product_name");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .HasConstraintName("fk_products_to_manufacturers");

            entity.HasOne(d => d.ProductCatigory).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductCatigori)
                .HasConstraintName("fk_products_to_product_catigories");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("fk_products_to_suppliers");

            entity.HasOne(d => d.UnitsOfMeasurement).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdUnit)
                .HasConstraintName("fk_products_to_units_of_measurement");
        });

        modelBuilder.Entity<ProductCatigory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_product_catigories_id");

            entity.ToTable("product_catigories");

            entity.HasIndex(e => e.ProductCatigoriName, "uk_product_catigori_name_product_catigories").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProductCatigoriName).HasColumnName("product_catigori_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles_id");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "uk_role_name_roles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_suppliers_id");

            entity.ToTable("suppliers");

            entity.HasIndex(e => e.SupplierName, "uk_supplier_name_suppliers").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SupplierName).HasColumnName("supplier_name");
        });

        modelBuilder.Entity<UnitsOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sunits_of_measurement_id");

            entity.ToTable("units_of_measurement");

            entity.HasIndex(e => e.UnitName, "uk_unit_name_units_of_measurement").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UnitName).HasColumnName("unit_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users_id");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "uk_login_users").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Nickname)
                .HasMaxLength(100)
                .HasColumnName("nickname");
            entity.Property(e => e.Pasvord)
                .HasMaxLength(100)
                .HasColumnName("pasvord");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_useres_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
