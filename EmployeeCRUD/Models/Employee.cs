using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Models;

[Index("Email", Name = "UQ__Employee__A9D10534E188DDD5", IsUnique = true)]
public partial class Employee
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    public int? Age { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Salary { get; set; }
}
