using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IVehicle
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
}
