using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _data;

    public BookingProcessor(IData data) => _data = data;

    public List<IBooking> GetBookings() => _data.GetBookings();
    public List<IPerson> GetCustomers() => _data.GetCustomers();
    public List<IVehicle> GetVehicles(VehicleStatuses status = default) => _data.GetVehicles(status);
}

