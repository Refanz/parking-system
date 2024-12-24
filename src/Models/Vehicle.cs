namespace ParkingSystem.Models
{
    public class Vehicle(string vehicleNumber, string color, string type)
    {
        public string VehicleNumber { get; set; } = vehicleNumber;

        public string Color { get; set; } = color;

        public string Type { get; set; } = type;

        public int Slot { get; set; }


        public override string ToString()
        {
            return Type + " " + Color + " " + Slot;
        }
    }
}