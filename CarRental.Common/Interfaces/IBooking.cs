using CarRental.Common.Classes;

namespace CarRental.Common.Interfaces;

public interface IBooking
{
    public int Id { get; }
    public string RegNr { get; init; }
    public Customer Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateTime DayRented { get; init; }
    public DateTime DayReturned { get; init; }
    public bool BookingOpen { get; set; }
    public double CostTotal { get; }
    public double GetCost();
}
