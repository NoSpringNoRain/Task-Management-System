using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class TaskManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskHistory> TasksHistory { get; set; }

        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<Task>(ConfigureTask);
            modelBuilder.Entity<TaskHistory>(ConfigureTaskHistory);
        }

        private void ConfigureTaskHistory(EntityTypeBuilder<TaskHistory> builder)
        {
            builder.ToTable("Tasks History");
            builder.HasKey(th => th.TaskId);
            builder.Property(th => th.TaskId).ValueGeneratedNever();
            builder.HasOne(th => th.User).WithMany(u => u.TasksHistory)
                .HasForeignKey(th => th.UserId);
            builder.Property(th => th.Title).HasMaxLength(50);
            builder.Property(th => th.Description).HasMaxLength(500);
            builder.Property(th => th.DueDate).HasColumnType("datetime");
            builder.Property(th => th.Completed).HasColumnType("datetime");
            builder.Property(th => th.Remarks).HasMaxLength(500);
        }

        private void ConfigureTask(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Tasks");
            builder.HasKey(t => t.Id);
            builder.HasOne(t => t.User).WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId);
            builder.Property(t => t.Title).HasMaxLength(50);
            builder.Property(t => t.Description).HasMaxLength(500);
            builder.Property(t => t.DueDate).HasColumnType("datetime");
            builder.Property(t => t.Priority).HasColumnType("char(1)");
            builder.Property(t => t.Remarks).HasMaxLength(500);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Password).HasMaxLength(10).IsRequired();
            builder.Property(u => u.Fullname).HasMaxLength(50);
            builder.Property(u => u.Mobileno).HasMaxLength(50);
        }
    }
}