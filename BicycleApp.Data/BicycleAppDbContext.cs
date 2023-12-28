namespace BicycleApp.Data
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Data.SeedData;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class BicycleAppDbContext : IdentityDbContext<BaseUser, BaseUserRole, string>
    {
        public BicycleAppDbContext() : base()
        {

        }

        public BicycleAppDbContext(DbContextOptions<BicycleAppDbContext> options)
            : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-O0P5VDC\\SQLEXPRESS;Database=BicycleNewDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False");
        //}

        //Identity Tables
        public virtual DbSet<BaseUser> BaseUsers { get; set; } = null!;
        public virtual DbSet<BaseUserRole> BaseUserRoles { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        //Entities
        public virtual DbSet<Town> Towns { get; set; } = null!;

        public virtual DbSet<Department> Departments { get; set; } = null!;

        public virtual DbSet<Part> Parts { get; set; } = null!;

        public virtual DbSet<PartCategory> PartCategories { get; set; } = null!;

        public virtual DbSet<ImagePart> ImagesParts { get; set; } = null!;

        public virtual DbSet<ImageClient> ImagesClients { get; set; } = null!;

        public virtual DbSet<ImageEmployee> ImagesEmployees { get; set; } = null!;

        public virtual DbSet<VATCategory> VATCategories { get; set; } = null!;

        public virtual DbSet<Rate> Rates { get; set; } = null!;

        public virtual DbSet<Delivary> Delivaries { get; set; } = null!;
        public virtual DbSet<DelivaryAddress> DelivaryAddresses { get; set; } = null!;

        public virtual DbSet<Suplier> Supliers { get; set; } = null!;

        public virtual DbSet<Comment> Comments { get; set; } = null!;

        public virtual DbSet<Order> Orders { get; set; } = null!;

        public virtual DbSet<Status> Statuses { get; set; } = null!;

        public virtual DbSet<OrderPartEmployee> OrdersPartsEmployees { get; set; } = null!;
        public virtual DbSet<OrderPartEmployeeInfo> OrdersPartsEmployeesInfos { get; set; } = null!;

        public virtual DbSet<BikeStandartModel> BikesStandartModels { get; set; } = null!;

        public virtual DbSet<BikeModelPart> BikeModelsParts { get; set; } = null!;
        public virtual DbSet<PartOrder> PartOrders { get; set; } = null!;
        public virtual DbSet<PartInStock> PartsInStock { get; set; } = null!;
        public virtual DbSet<CompatablePart> CompatableParts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //ClientEntityConfiguration
            builder.Entity<Client>(entity =>
            {
                entity
                    .HasOne(c => c.Town)
                    .WithMany(t => t.Clients)
                    .HasForeignKey(c => c.TownId)
                    .OnDelete(DeleteBehavior.NoAction);
                entity
                    .Property(c => c.Balance).HasColumnType("decimal(18,2)");
            });

            //EmployeeEntityConfiguration
            builder.Entity<Employee>(entity =>
            {
                entity
                    .HasOne(e => e.Department)
                    .WithMany(d => d.Employees)
                    .HasForeignKey(e => e.DepartmentId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //CommentEntityConfiguration
            builder.Entity<Comment>(entity =>
            {
                entity
                    .HasOne(c => c.Part)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(c => c.PartId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(c => c.Client)
                    .WithMany(cl => cl.Comments)
                    .HasForeignKey(c => c.ClientId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //DelivaryEntityConfiguration
            builder.Entity<Delivary>(entity =>
            {
                entity
                    .HasOne(d => d.Part)
                    .WithMany(p => p.Delivaries)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .Property(d => d.QuantityDelivered).HasColumnType("float(2)");

                entity
                    .HasOne(d => d.Suplier)
                    .WithMany(s => s.Delivaries)
                    .HasForeignKey(d => d.SuplierId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //ImagePartEntityConfiguration
            builder.Entity<ImagePart>(entity =>
            {
                entity
                    .HasOne(ip => ip.Part)
                    .WithMany(p => p.ImagesParts)
                    .HasForeignKey(p => p.PartId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //ImageClientEntityConfiguration
            builder.Entity<ImageClient>(entity =>
            {
                entity
                    .HasOne(ic => ic.Client)
                    .WithMany(c => c.Images)
                    .HasForeignKey(ic => ic.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //ImageEmployeeEntityConfiguration
            builder.Entity<ImageEmployee>(entity =>
            {
                entity
                    .HasOne(ie => ie.Employee)
                    .WithMany(e => e.ImagesEmployees)
                    .HasForeignKey(ie => ie.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //OrderEntityConfiguration
            builder.Entity<Order>(entity =>
            {
                entity
                    .HasOne(o => o.Client)
                    .WithMany(o => o.Orders)
                    .HasForeignKey(o => o.ClientId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .Property(o => o.Description).HasColumnType("nvarchar(max)");

                entity
                    .Property(o => o.SaleAmount).HasColumnType("decimal(18,2)");

                entity
                    .Property(o => o.Discount).HasColumnType("decimal(18,2)");

                entity
                    .Property(o => o.VAT).HasColumnType("decimal(18,2)");

                entity
                    .Property(o => o.FinalAmount).HasColumnType("decimal(18,2)");

                entity
                    .Property(o => o.PaidAmount).HasColumnType("decimal(18,2)");

                entity
                    .Property(o => o.UnpaidAmount).HasColumnType("decimal(18,2)");

                entity
                    .HasOne(o => o.Status)
                    .WithMany(s => s.Orders)
                    .HasForeignKey(o => o.StatusId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //OrderPartEmployeeEntityConfiguration
            builder.Entity<OrderPartEmployee>(entity =>
            {
                entity
                    .HasKey(ope => new { ope.OrderId, ope.PartId, ope.UniqueKeyForSerialNumber });

                entity
                    .HasOne(ope => ope.Order)
                    .WithMany(o => o.OrdersPartsEmployees)
                    .HasForeignKey(ope => ope.OrderId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(ope => ope.Part)
                    .WithMany(o => o.OrdersPartsEmployees)
                    .HasForeignKey(ope => ope.PartId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.Property(ope => ope.PartPrice).HasColumnType("decimal(18,2)");

                entity.Property(ope => ope.PartQuantity).HasColumnType("float(2)");
            });

            //OrderPartEmployeeInfoEntityConfiguration
            builder.Entity<OrderPartEmployeeInfo>(entity =>
            {
                entity
                     .HasOne(p => p.OrderPartEmployee)
                     .WithMany(p => p.OrdersPartsEmployeesInfos)
                     .HasForeignKey(k => new { k.OrderId, k.PartId, k.UniqueKeyForSerialNumber });
            });

            //PartEntityConfiguration
            builder.Entity<Part>(entity =>
             {
                 entity
                     .HasOne(p => p.Category)
                     .WithMany(pc => pc.Parts)
                     .HasForeignKey(p => p.CategoryId)
                     .OnDelete(DeleteBehavior.NoAction);

                 entity
                     .Property(p => p.Quantity).HasColumnType("float(2)");

                 entity
                     .Property(p => p.SalePrice).HasColumnType("decimal(18,2)");

                 entity
                     .Property(p => p.Discount).HasColumnType("decimal(18,2)");

                 entity
                     .HasOne(p => p.VATCategory)
                     .WithMany(v => v.Parts)
                     .HasForeignKey(p => p.VATCategoryId)
                     .OnDelete(DeleteBehavior.NoAction);
             });

            //PartOrderEntityConfiguration
            builder.Entity<PartOrder>(entity =>
            {
                entity
                    .HasOne(po => po.Part)
                    .WithMany()
                    .HasForeignKey(p => p.PartId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //RateEntityConfiguration
            builder.Entity<Rate>(entity =>
            {
                entity
                    .HasKey(r => new { r.PartId, r.ClientId });

                entity
                    .HasOne(r => r.Client)
                    .WithMany(c => c.Rates)
                    .HasForeignKey(r => r.ClientId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                  .HasOne(r => r.Part)
                  .WithMany(p => p.Rates)
                  .HasForeignKey(r => r.PartId)
                  .OnDelete(DeleteBehavior.NoAction);
            });

            //VATCategoryEntityConfiguration
            builder.Entity<VATCategory>(entity =>
            {
                entity
                    .Property(v => v.VATPercent).HasColumnType("decimal(6,2)");
            });

            //BikeStandartModelEntityConfiguration
            builder.Entity<BikeStandartModel>(entity =>
            {
                entity.Property(b => b.Price).HasColumnType("decimal(18,2)");
            });


            //BikeModelPartEntityConfiguration
            builder.Entity<BikeModelPart>(entity =>
            {
                entity.HasKey(b => new { b.PartId, b.BikeModelId });

                entity
                    .HasOne(bp => bp.BikeModel)
                    .WithMany(bm => bm.BikeModelsParts)
                    .HasForeignKey(bp => bp.BikeModelId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(bp => bp.Part)
                    .WithMany(p => p.BikeModelsParts)
                    .HasForeignKey(bp => bp.BikeModelId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            //Seed Test Data
            var seeder = new SeedClass();

            builder.Entity<Client>(entity => entity.HasData(seeder.SeedClients()));
            builder.Entity<Employee>(entity => entity.HasData(seeder.SeedEmployees()));
            builder.Entity<Comment>(entity => entity.HasData(seeder.SeedComments()));
            builder.Entity<Delivary>(entity => entity.HasData(seeder.SeedDelivaries()));
            builder.Entity<Department>(entity => entity.HasData(seeder.SeedDepartments()));
            builder.Entity<ImagePart>(entity => entity.HasData(seeder.SeedImagesParts()));
            builder.Entity<ImageClient>(entity => entity.HasData(seeder.SeedImagesClients()));
            builder.Entity<ImageEmployee>(entity => entity.HasData(seeder.SeedImagesEmployees()));
            builder.Entity<Order>(entity => entity.HasData(seeder.SeedOrders()));
            builder.Entity<OrderPartEmployee>(entity => entity.HasData(seeder.SeedOrdersPartsEmployees()));
            builder.Entity<OrderPartEmployeeInfo>(entity => entity.HasData(seeder.SeedOrderOrderParsEmployeeInfos()));
            builder.Entity<Part>(entity => entity.HasData(seeder.SeedParts()));
            builder.Entity<PartCategory>(entity => entity.HasData(seeder.SeedPartCategories()));
            builder.Entity<Rate>(entity => entity.HasData(seeder.SeedRates()));
            builder.Entity<Status>(entity => entity.HasData(seeder.SeedStatuses()));
            builder.Entity<Suplier>(entity => entity.HasData(seeder.SeedSuplieres()));
            builder.Entity<Town>(entity => entity.HasData(seeder.SeedTowns()));
            builder.Entity<DelivaryAddress>(entity => entity.HasData(seeder.SeedDelivaryAddresses()));
            builder.Entity<VATCategory>(entity => entity.HasData(seeder.SeedVATCategories()));
            builder.Entity<PartInStock>(entity => entity.HasData(seeder.SeedPartsInStock()));
            builder.Entity<PartOrder>(entity => entity.HasData(seeder.SeedPartOrders()));
            builder.Entity<BaseUserRole>(entity => entity.HasData(seeder.SeedRoles()));
            builder.Entity<IdentityUserRole<string>>(entity => entity.HasData(seeder.SeedRolesUsers()));
            builder.Entity<BikeStandartModel>(entity => entity.HasData(seeder.SeedBikeStandartModels()));
            builder.Entity<BikeModelPart>(entity => entity.HasData(seeder.SeedBikeModelPartls()));

            base.OnModelCreating(builder);
        }
    }
}
