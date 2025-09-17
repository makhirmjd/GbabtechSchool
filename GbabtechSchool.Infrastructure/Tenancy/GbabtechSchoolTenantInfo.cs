using Finbuckle.MultiTenant.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace GbabtechSchool.Infrastructure.Tenancy;

public class GbabtechSchoolTenantInfo : ITenantInfo
{
    [Required]
    public string? Id { get; set; }
    [Required]
    public string? Identifier { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? ConnectionString { get; set; }
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTimeOffset ValidUpTo { get; set; }
    public bool IsActive { get; set; }
}
