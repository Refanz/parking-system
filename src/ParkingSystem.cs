using ParkingSystem.Models;

namespace ParkingSystem
{
    public class ParkingSystem
    {
        private ParkingLot _parkingLot;

        public void CreateParkingLot(int slot)
        {
            _parkingLot = new ParkingLot(slot);
            Console.WriteLine("Created parking lot with " + _parkingLot.Capacity() + " slots");
        }

        public void Park(Vehicle vehicle)
        {
            _parkingLot.AddVehicle(vehicle);
        }

        public void Leave(int slot)
        {
            _parkingLot.RemoveVehicle(slot);
        }

        public void Status()
        {
            if (_parkingLot.Count() == 0)
            {
                Console.WriteLine("Parking lot is empty");
                return;
            }

            Console.WriteLine("Slot" + "\t" + "Registration No" + "\t" + "Type" + "\t" + "Color");
            foreach (Vehicle vehicle in _parkingLot.GetAllVehicles())
            {
                if (vehicle == null) continue;

                Console.WriteLine(vehicle.Slot + "\t" + vehicle.VehicleNumber + "\t" + vehicle.Type + "\t" +
                                  vehicle.Color);
            }
        }

        public void ShowRegistrationNumbersForVehiclesWithOddOrEvenPlate(bool isEven)
        {
            string[] registrationNumbers = _parkingLot.GetRegistrationNumbersVehicleByOddEven(isEven);
            Console.WriteLine(String.Join(", ", registrationNumbers));
        }

        public void ShowCountOfVehiclesByType(string type)
        {
            Console.WriteLine(_parkingLot.GetVehicleCountByType(type));
        }

        public void ShowSlotNumbersVehiclesByColor(string color)
        {
            int[] slotNumbersVehiclesByColor = _parkingLot.GetSlotNumbersVehiclesByColor(color);

            Console.WriteLine(slotNumbersVehiclesByColor.Length);

            if (slotNumbersVehiclesByColor.Length > 0)
                Console.WriteLine(String.Join(", ", slotNumbersVehiclesByColor));
        }

        public void ShowRegistrationNumbersVehiclesByColor(string color)
        {
            string[] numbersVehicleByColor = _parkingLot.GetRegistrationNumbersVehicleByColor(color);

            if (numbersVehicleByColor.Length.Equals(0))
            {
                Console.WriteLine("There are no " + color + " vehicles");
                return;
            }

            Console.WriteLine(String.Join(",", numbersVehicleByColor));
        }

        public void ShowSlotNumberVehicleByRegistrationNumber(string registrationNumber)
        {
            Console.WriteLine(_parkingLot.GetSlotNumberVehicleByRegistrationNumber(registrationNumber));
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}