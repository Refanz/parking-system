namespace ParkingSystem.Models
{
    public class ParkingLot(int slot)
    {
        private readonly Vehicle[] _vehicles = new Vehicle[slot];
        private int _count;

        public void AddVehicle(Vehicle vehicle)
        {
            if (_count == Capacity())
            {
                Console.WriteLine("Sorry, parking lot is full");
                return;
            }

            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] == null)
                {
                    vehicle.Slot = i + 1;
                    _vehicles[i] = vehicle;
                    _count++;

                    Console.WriteLine("Allocated slot number: " + (i + 1));
                    break;
                }
            }
        }

        public void RemoveVehicle(int slot)
        {
            if (slot > _vehicles.Length)
            {
                Console.WriteLine("The number of slots in the parking lot is only " + _vehicles.Length);
                return;
            }

            _count--;
            _vehicles[slot - 1] = null;

            Console.WriteLine("Slot number " + slot + " is free");
        }

        public int GetVehicleCountByType(string type)
        {
            int count = 0;

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle == null) continue;

                if (vehicle.Type.ToLower().Equals(type.ToLower()))
                    count++;
            }

            return count;
        }

        public string[] GetRegistrationNumbersVehicleByOddEven(bool isEven)
        {
            string result = "";

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle == null) continue;

                string[] temp = vehicle.VehicleNumber.Split("-");
                int registrationNumber = int.Parse(temp[1]);

                if (isEven)
                {
                    if (registrationNumber % 2 == 0)
                        result += vehicle.VehicleNumber + " ";
                }

                if (!isEven)
                {
                    if (registrationNumber % 2 == 1)
                        result += vehicle.VehicleNumber + " ";
                }
            }

            return result.Trim().Split(" ");
        }

        public int[] GetSlotNumbersVehiclesByColor(string color)
        {
            string tempNumber = "";

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle == null) continue;

                if (vehicle.Color.ToLower().Equals(color.ToLower()))
                    tempNumber += vehicle.Slot + " ";
            }

            if (tempNumber.Equals(""))
                return [];

            return tempNumber.Trim().Split(" ").Select(int.Parse).ToArray();
        }

        public string[] GetRegistrationNumbersVehicleByColor(string color)
        {
            string result = "";

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle == null) continue;

                if (vehicle.Color.ToLower().Equals(color.ToLower()))
                    result += vehicle.VehicleNumber + " ";
            }

            if (result.Equals(""))
                return [];

            return result.Trim().Split(" ");
        }

        public int GetSlotNumberVehicleByRegistrationNumber(string registrationNumber)
        {
            int result = 0;

            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle == null) continue;

                if (vehicle.VehicleNumber.Equals(registrationNumber))
                {
                    result = vehicle.Slot;
                    break;
                }
            }

            return result;
        }

        public int Capacity()
        {
            return _vehicles.Length;
        }

        public int Count()
        {
            return _count;
        }

        public Vehicle[] GetAllVehicles()
        {
            return _vehicles;
        }
    }
}