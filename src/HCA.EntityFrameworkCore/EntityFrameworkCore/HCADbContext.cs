using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HCA.Authorization.Roles;
using HCA.Authorization.Users;
using HCA.MultiTenancy;
using HCA.Notification;
using HCA.Permissions;
using HCA.Subscription;
using HCA.Industry;
using HCA.CrewGroup;
using HCA.ServiceArea;
using HCA.TechnicinaType;
using HCA.Employee;
using HCA.Customer;
using HCA.CatalogServices;
using HCA.Jobs;
using HCA.WebSite_Configuration.Slider;
using HCA.WebSite_Configuration.Service;
using HCA.WebSite_Configuration.Blog;
using HCA.Leads;

namespace HCA.EntityFrameworkCore
{
    public class HCADbContext : AbpZeroDbContext<Tenant, Role, User, HCADbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Packages.Package> Packages { get; set; }
        public DbSet<Notifications> tblNotifications { get; set; }

        public DbSet<Industry.Industry> Industries { get; set; }
        public DbSet<TenantPackageSubscription> tenantPackagesubscriptions { get; set; }

        public DbSet<Employee.Technician> Technician { get; set; }
        public DbSet<TechnicianTypes> TechnicianTypes { get; set; }
        public DbSet<Employee.Attachments> Attachments { get; set; }
        public DbSet<CrewGroups> CrewGroups { get; set; }
        public DbSet<ServiceAreas> ServiceAreas { get; set; }
        public DbSet<Shift.Shifts> Shifts { get; set; }
        public DbSet<States.State> States { get; set; }
        public DbSet<Cities.City> Cities { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Sites> Sites { get; set; }
        public DbSet<Transactions.Transactions> Transactions { get; set; }
        public DbSet<DiagnosticService> DiagnosticServices { get; set; }
        public DbSet<DiagnosticType> DiagnosticTypes { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartType> PartTypes { get; set; }
        public DbSet<RepairService> RepairServices { get; set; }
        public DbSet<RepairServiceType> RepairServiceTypes { get; set; }
        public DbSet<ServiceContracts> ServiceContracts { get; set; }
        public DbSet<ServiceContractType> ServiceContractTypes { get; set; }
        public DbSet<WarrantyClaimService> WarrantyClaimServices { get; set; }
        public DbSet<WarrantyClaimServiceType> WarrantyClaimServiceTypes { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<JobType> Jobtypes { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<JobChecklist> JobChecklist { get; set; }
        public DbSet<TechnicianJob> TechnicianJob { get; set; }

        public DbSet<TechnicianServices> TechnicianServices { get; set; }
        public DbSet<JobService> JobService { get; set; }

        public DbSet<Slider> Slider { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogAuthor> BlogAuthors { get; set; }
        public DbSet<BlogImageGallery> BlogImageGalleries { get; set; }
        public DbSet<BlogBottom> BlogBottoms { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<FactAndFigure> FactAndFigures { get; set; }
        public DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.BlogAuthor)
                .WithMany(a => a.Blogs)
                .HasForeignKey(b => b.BlogAuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.ImageGallery)
                .WithMany(ig => ig.Blogs)
                .HasForeignKey(b => b.ImageGalleryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.BlogBottom)
                .WithMany(bb => bb.Blogs)
                .HasForeignKey(b => b.BlogBottomId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BlogComment>()
                .HasOne(bc => bc.Blog)
                .WithMany(b => b.CommentsList)
                .HasForeignKey(bc => bc.BlogId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BlogComment>()
                .HasOne(bc => bc.BlogAuthor)
                .WithMany(a => a.BlogComments)
                .HasForeignKey(bc => bc.BlogAuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public HCADbContext(DbContextOptions<HCADbContext> options)
            : base(options)
        {
        }
    }
}