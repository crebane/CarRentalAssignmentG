using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public int Id { get; }
    public string RegNr { get; init; }
    public Customer Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateTime DayRented { get; init; }
    public DateTime DayReturned { get; init; }
    public double CostKm { get; init; }
    public double CostDay { get; init; }
    public bool BookingOpen { get; set; }
    public double CostTotal { get => GetCost(); }

    public Booking(string regNr, Customer customer, int kmRented, int kmReturned, double costDay, double costKm, DateTime dayRented, DateTime dayReturned, bool bookingOpen)
    {
        RegNr = regNr;
        Customer = customer;
        KmRented = kmRented;
        KmReturned = kmReturned;
        CostDay = costDay;
        CostKm = costKm;
        DayRented = dayRented;
        DayReturned = dayReturned;
        BookingOpen = bookingOpen;
    }
    public double GetCost()
    {
        double daysRented = (DayReturned - DayRented).TotalDays;
        int kmDroven = KmReturned - KmRented;
        return (daysRented * CostDay) + (kmDroven * CostKm);
    }
}