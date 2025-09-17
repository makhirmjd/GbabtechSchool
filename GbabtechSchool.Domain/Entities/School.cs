namespace GbabtechSchool.Domain.Entities;

public class School : BaseEntity
{
    public string Name { get; set; } = default!;
    public DateTimeOffset EstablishedDate { get; set; }
}
