namespace ProgrammingCoaching.SOLID.Data.Models;

public class CarFilterOptions {
    public CarType? CarType;
    public CarTrack? CarTrack;
    public int MinNumberOfDoors;
    public int MinNumberOfSeats;
    public int Year;
    public int MaxPrice;
    public bool TryDiscount;
}