using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IVehicle> Vehicles = new();
    readonly List<IPerson> Customers = new();
    readonly List<IBooking> Bookings = new();
    public CollectionData() => SeedData();

    public void SeedData()
    {
        Vehicles.Add(new Car(1, "ABC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200, true, VehicleStatuses.Available));
        Vehicles.Add(new Car(2, "DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100, true, VehicleStatuses.Available));
        Vehicles.Add(new Car(3, "GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, false, VehicleStatuses.Booked));
        Vehicles.Add(new Car(4, "JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, true, VehicleStatuses.Available));
        Vehicles.Add(new Motorcycle(5, "MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50, true, VehicleStatuses.Available));

        Customers.Add(new Customer("12345", "John", "Doe"));
        Customers.Add(new Customer("98765", "Jane", "Doe"));

        Bookings.Add(new Booking(Vehicles[2].RegNr, (Customer)Customers[0], Vehicles[2].Odometer, default, Vehicles[2].CostDay, Vehicles[2].CostKm, new DateTime(2023, 9, 20), new DateTime(), true));
        Bookings.Add(new Booking(Vehicles[3].RegNr, (Customer)Customers[1], Vehicles[3].Odometer, 5200, Vehicles[3].CostDay, Vehicles[2].CostKm, new DateTime(2023, 9, 20), new DateTime(2023, 9, 22), false));
    }

    public List<IVehicle> GetVehicles(VehicleStatuses status = default) => Vehicles;
    public List<IPerson> GetCustomers() => Customers;
    public List<IBooking> GetBookings() => Bookings;
}
