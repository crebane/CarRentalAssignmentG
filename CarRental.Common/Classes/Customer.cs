using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Customer : IPerson
{
    public int Id { get; }
    public string SocialSecurityNumber { get; init; }
    public string LastName { get; init; }
    public string FirstName { get; init; }

    public Customer(string socialSecurityNumber, string lastName, string firstName)
    {
        SocialSecurityNumber = socialSecurityNumber;
        LastName = lastName;
        FirstName = firstName;
    }
}
