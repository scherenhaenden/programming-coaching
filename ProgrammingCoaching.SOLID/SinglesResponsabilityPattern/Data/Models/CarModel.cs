namespace ProgrammingCoaching.SOLID.SinglesResponsabilityPattern.Data.Models;

public class CarModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfSeats { get; set; }
    
    public CarType CarType { get; set; }
    
    public CarTrack CarTrack { get; set; }
}