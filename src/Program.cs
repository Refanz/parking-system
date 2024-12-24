namespace ParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem();
            
            ParkingMenu parkingMenu = new ParkingMenu(parkingSystem);
            parkingMenu.StartParkingMenu();
        }
    }
}