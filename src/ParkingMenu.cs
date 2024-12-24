using ParkingSystem.Models;

namespace ParkingSystem;

public class ParkingMenu
{
    private readonly ParkingSystem _parkingSystem;

    public ParkingMenu(ParkingSystem parkingSystem)
    {
        _parkingSystem = parkingSystem;
        InitialData();
    }

    private void InitialData()
    {
        _parkingSystem.CreateParkingLot(10);
        
        _parkingSystem.Park(new Car("B-1234-XYZ", "Putih"));
        _parkingSystem.Park(new Motorcycle("B-9999-XYZ", "Putih"));
        _parkingSystem.Park(new Car("D-0001-HIJ", "Hitam"));
        _parkingSystem.Park(new Car("B-7777-DEF", "Merah"));
        _parkingSystem.Park(new Car("B-2701-XXX", "Biru"));
        _parkingSystem.Park(new Motorcycle("B-3141-ZZZ", "Hitam"));
    }

    public void StartParkingMenu()
    {
        while (true)
        {
            ShowMainMenu();

            Console.WriteLine("Ingin melanjutkan (Y/t)? ");
            string option = Console.ReadLine();

            if (option != null && (option.Equals("t") || option.Equals("T"))) break;
        }
    }

    private void ShowMainMenu()
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("             PARKING LOT APP             ");
        Console.WriteLine("=========================================");
        Console.WriteLine("1. Park");
        Console.WriteLine("2. Leave");
        Console.WriteLine("3. Status");
        Console.WriteLine("4. Show Count of Vehicles by Type");
        Console.WriteLine("5. Show Registration Numbers of Vehicles By Odd or Event Plate");
        Console.WriteLine("6. Show Registration Numbers of Vehicles By Color");
        Console.WriteLine("7. Show Slot Numbers for Vehicles By Color");
        Console.WriteLine("8. Show Slot Number for Vehicle By Registration Number");
        Console.WriteLine("9. Exit");

        Console.WriteLine("Masukkan menu (1 - 9): ");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                ShowParkMenu();
                break;
            case "2":
                ShowLeaveMenu();
                break;
            case "3":
                _parkingSystem.Status();
                break;
            case "4":
                ShowGetCountVehiclesByTypeMenu();
                break;
            case "5":
                ShowGetRegistrationNumbersOfVehiclesByOddOrEvenPlateMenu();
                break;
            case "6":
                ShowGetRegistrationNumbersOfVehiclesByColorMenu();
                break;
            case "7":
                ShowGetSlotNumbersVehiclesByColorMenu();
                break;
            case "8":
                ShowSlotNumberVehicleByRegistrationNumberMenu();
                break;
            case "9":
                _parkingSystem.Exit();
                break;
            default:
                Console.WriteLine("Menu yang anda masukkan tidak tersedia!");
                break;
        }
    }

    private void ShowParkMenu()
    {
        Console.WriteLine("Masukkan data kendaraan");
        Console.WriteLine("Nomor Kendaraan: ");
        string vehicleNumber = Console.ReadLine();

        Console.WriteLine("Warna: ");
        string color = Console.ReadLine();

        Console.WriteLine("Jenis Kendaraan: ");
        string type = Console.ReadLine();

        Vehicle vehicle = null;

        if (type.ToLower().Equals("motor"))
            vehicle = new Motorcycle(vehicleNumber, color);

        if (type.ToLower().Equals("mobil"))
            vehicle = new Car(vehicleNumber, color);

        _parkingSystem.Park(vehicle);
    }

    private void ShowLeaveMenu()
    {
        Console.WriteLine("Masukkan Nomor Slot Kendaraan: ");
        int slot = int.Parse(Console.ReadLine());

        _parkingSystem.Leave(slot);
    }

    private void ShowGetCountVehiclesByTypeMenu()
    {
        Console.WriteLine("Masukkan Tipe Kendaraan: ");
        string type = Console.ReadLine();
        
        _parkingSystem.ShowCountOfVehiclesByType(type);
    }

    private void ShowGetRegistrationNumbersOfVehiclesByOddOrEvenPlateMenu()
    {
        Console.WriteLine("Masukkan pilihan ganjil atau genap (ganjil/genap): ");
        string option = Console.ReadLine();

        if (option.ToLower().Equals("genap"))
            _parkingSystem.ShowRegistrationNumbersForVehiclesWithOddOrEvenPlate(true);

        if (option.ToLower().Equals("ganjil"))
            _parkingSystem.ShowRegistrationNumbersForVehiclesWithOddOrEvenPlate(false);
    }

    private void ShowGetRegistrationNumbersOfVehiclesByColorMenu()
    {
        Console.WriteLine("Masukkan warna: ");
        string color = Console.ReadLine();
        _parkingSystem.ShowRegistrationNumbersVehiclesByColor(color);
    }

    private void ShowGetSlotNumbersVehiclesByColorMenu()
    {
        Console.WriteLine("Masukkan warna: ");
        string color = Console.ReadLine();
        _parkingSystem.ShowSlotNumbersVehiclesByColor(color);
    }

    private void ShowSlotNumberVehicleByRegistrationNumberMenu()
    {
        string registrationNumber = Console.ReadLine();
        _parkingSystem.ShowSlotNumberVehicleByRegistrationNumber(registrationNumber);
    }
}