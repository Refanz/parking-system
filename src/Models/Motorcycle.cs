namespace ParkingSystem.Models
{
    public class Motorcycle(string vehicleNumber, string color)
        : Vehicle(vehicleNumber, color, type: "Motor");
}