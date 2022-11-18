using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RocketApi.Models
{
    // Name of the public class below is RocketElevatorContext because it involves the whole Rocket ////Elevator Database, so to not mix this with the actual elevator models or controller it should be named as it is in this commit.
    public class RocketElevatorContext : DbContext
    {
        public RocketElevatorContext(DbContextOptions<RocketElevatorContext> options)
            : base(options)
        {
        }

        public DbSet<Elevator> elevators { get; set; } = null!;

        public DbSet<Column> columns { get; set; } = null!;
        public DbSet<batteries> batteries { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<BuildingDetail> BuildingDetails { get; set; } = null!;
       // public virtual DbSet<BuildingType> BuildingTypes { get; set; } = null!;
       
        public virtual DbSet<Lead> Lead { get; set; } = null!;
         
         
        public IEnumerable<batteries> GetItem()
        {
            return batteries;
        }

        public IEnumerable<batteries> PostBatteries()
        {
            return batteries;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=ls-f2d6bd226744c0fcfc2009d804298a21ce412d05.crydppxblqbm.ca-central-1.rds.amazonaws.com;port=3306;database=GianlucaCiccone;uid=academy;password=HeAz+=Sc-8CJ3bXv", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8mb3");
                
                 modelBuilder.Entity<Lead>(entity =>
            {
                entity.ToTable("leads");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                // entity.Property(e => e.Date)
                //     .HasColumnType("datetime")
                //     .HasColumnName("date");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .HasColumnName("department");

                entity.Property(e => e.DescriptionProject)
                    .HasMaxLength(255)
                    .HasColumnName("project_description");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                

                entity.Property(e => e.FullNameContact)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .HasColumnName("message");

                entity.Property(e => e.NameProject)
                    .HasMaxLength(255)
                    .HasColumnName("project_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });
        
        modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.UserId, "index_customers_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

               

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(255)
                    .HasColumnName("company_contact_phone");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("customer_creation_date");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("company_description");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email_of_company_contact");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name_of_company_contact");

                entity.Property(e => e.FullNameTechnicalAuthority)
                    .HasMaxLength(255)
                    .HasColumnName("full_name_of_service_technical_authority");

                entity.Property(e => e.TechnicalAuthorityEmail)
                    .HasMaxLength(255)
                    .HasColumnName("technical_manager_email_for_service");

                entity.Property(e => e.TechnicalAuthorityPhone)
                    .HasMaxLength(255)
                    .HasColumnName("technical_authority_phone_for_service");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });
        
             
            
            modelBuilder.Entity<Building>(entity =>
            {
                entity.ToTable("buildings");

                entity.HasIndex(e => e.CustomerId, "index_buildings_on_customer_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressOfBuilding)
                    .HasMaxLength(255)
                    .HasColumnName("Address_of_the_building");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EmailBuildingAdmin)
                    .HasMaxLength(255)
                    .HasColumnName("Email_of_the_administrator_of_the_building");

                entity.Property(e => e.EmailTechnicalAuthority)
                    .HasMaxLength(255)
                    .HasColumnName("Technical_contact_email_for_the_building");

                entity.Property(e => e.FullNameBuildingAdmin)
                    .HasMaxLength(255)
                    .HasColumnName("Full_Name_of_the_building_administrator");

                entity.Property(e => e.FullNameTechnicalAuthority)
                    .HasMaxLength(255)
                    .HasColumnName("Full_Name_of_the_technical_contact_for_the_building");

                entity.Property(e => e.PhoneBuildingAdmin)
                    .HasMaxLength(255)
                    .HasColumnName("Phone_number_of_the_building_administrator");

                entity.Property(e => e.PhoneTechnicalAuthority)
                    .HasMaxLength(255)
                    .HasColumnName("Technical_contact_phone_for_the_building");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<BuildingDetail>(entity =>
            {
                entity.ToTable("buildings_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuildingId).HasColumnName("building_id");

                entity.Property(e => e.InformationKey).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("text");
            });
            modelBuilder.Entity<Column>(entity =>
            {
                entity.ToTable("columns");
                entity.HasIndex(e => e.battery_id, "index_columns_on_battery_id");
                entity.Property( e => e.id).HasColumnName ("id");
                entity.Property( e => e.battery_id).HasColumnName("battery_id");
                
                entity.Property(e =>e.status)
                .HasMaxLength(255)
                .HasColumnName("status");
            });

           modelBuilder.Entity<batteries>(entity =>
            {
                entity.ToTable("batteries");
                entity.HasIndex(e => e.building_id, "index_columns_on_building_id");
                entity.Property( e => e.Id).HasColumnName ("id");
                entity.Property( e => e.building_id).HasColumnName("building_id");
                
                entity.Property(e =>e.status)
                .HasMaxLength(255)
                .HasColumnName("status");
            });
              modelBuilder.Entity<Elevator>(entity =>
            {
                entity.ToTable("elevators");

                entity.HasIndex(e => e.column_id, "index_elevators_on_column_id");

                entity.Property(e => e.Id).HasColumnName("id");

                 entity.Property(e => e.status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
            });   


}}}