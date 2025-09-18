using GbabtechSchool.Shared.Entities;

namespace GbabtechSchool.Domain.Entities;

public class School : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public DateTimeOffset EstablishedDate { get; set; }
}
