namespace ParkingSystem.Models
{
    public class Car(string vehicleNumber, string color) : Vehicle(vehicleNumber, color, type: "Mobil");
}