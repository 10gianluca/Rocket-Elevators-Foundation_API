using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RocketApi.Models
{
    public class ElevatorContext : DbContext
    {
        public ElevatorContext(DbContextOptions<ElevatorContext> options)
            : base(options)
        {
        }

        public DbSet<Elevator> elevators { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<BuildingDetail> BuildingDetails { get; set; } = null!;
        public virtual DbSet<BuildingType> BuildingTypes { get; set; } = null!;
       
        public virtual DbSet<Lead> Lead { get; set; } = null!;
         

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
        
              modelBuilder.Entity<BuildingType>(entity =>
            {
                entity.ToTable("building_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("companyName");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.NumberApartments).HasColumnName("number_apartments");

                entity.Property(e => e.NumberElevators).HasColumnName("number_elevators");

                entity.Property(e => e.NumberFloors).HasColumnName("number_floors");

                entity.Property(e => e.NumberOccupants).HasColumnName("number_occupants");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });
        }}}

            

    