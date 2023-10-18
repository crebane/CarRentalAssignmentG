using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Data.Interfaces;

public interface IData
{
    List<IPerson> GetCustomers();
    List<IVehicle> GetVehicles(VehicleStatuses status = default);
    List<IBooking> GetBookings();
}