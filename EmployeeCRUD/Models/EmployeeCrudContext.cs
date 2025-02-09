using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Models;

public partial class EmployeeCRUDContext : DbContext
{
    public EmployeeCRUDContext()
    {
    }

    public EmployeeCRUDContext(DbContextOptions<EmployeeCRUDContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07903CFBB2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
