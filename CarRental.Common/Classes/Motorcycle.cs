using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Motorcycle : IVehicle
{
    public int Id { get; init; }
    public string? RegNr { get; init; }
    public string? Make { get; init; }
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public VehicleTypes Type { get; init; }
    public double CostDay { get; init; }
    public VehicleStatuses Status { get; set; }
    public bool IsAvailable { get; set; }

    public Motorcycle(int id, string regNr, string make, int odometer, double costKm, VehicleTypes type, double costDay, bool isAvaliable, VehicleStatuses status)
    {
        Id = id;
        RegNr = regNr;
        Make = make;
        Odometer = odometer;
        CostKm = costKm;
        Type = type;
        CostDay = costDay;
        IsAvailable = isAvaliable;
        Status = status;
    }
}
