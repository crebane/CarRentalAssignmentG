namespace CarRental.Common.Interfaces;

public interface IPerson
{
    public int Id { get; }
    public string SocialSecurityNumber { get; init; }
    public string LastName { get; init; }
    public string FirstName { get; init; }
}
