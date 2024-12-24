# Parking System

## Description
Parking System is a simple console application developed in C# to manage parking operations. 
The application demonstrates the use of object-oriented programming principles by implementing various classes and methods. 
It simulates a parking system for different types of vehicles such as cars and motorcycles.

## Project Structure
The project is organized into the following directories and classes:

### Folder: `models`
This folder contains the model classes that represent the core entities of the application.

#### Classes:
1. **Motorcycle**
    - Represents a motorcycle.
    - Inherits from the `Vehicle` class.

2. **Car**
    - Represents a car.
    - Inherits from the `Vehicle` class.

3. **Vehicle**
    - The base class for all vehicle types.
    - Contains common properties such as `VehicleNumber`, `Type`, `Color`, `Slot`.

4. **ParkingLot**
    - Custom data type to manage parking operations.
    - Contains methods for:
        - Adding vehicles to the parking lot.
        - Removing vehicles from the parking lot.
        - Displaying the status of the parking lot.
        - Get Vehicle Registration Numbers by Odd or Even Plate
        - Get Vehicle Registration Numbers by Color
        - Get Vehicle Slot Numbers by Color
        - Get Vehicle Slot Number by Registration Number

### Folder: `src`
This folder contains the source files responsible for the application's main functionality and user interaction.

#### Classes:
1. **Program**
    - The main class where the application starts execution.
    - Responsible for initializing the application and invoking the menu.

2. **ParkingMenu**
    - Contains methods to display menu options to the user.
    - Provides options such as:
        - Parking a vehicle.
        - Retrieving a vehicle.
        - Viewing parking lot status.
        - Exiting the application.

3. **ParkingSystem**
    - Coordinates between `ParkingMenu` and `ParkingLot`.
    - Calls methods in the `ParkingLot` class based on user actions.

## Features
- **Vehicle Parking**: Allows parking of cars and motorcycles.
- **Vehicle Retrieval**: Enables users to retrieve their parked vehicles.
- **Parking Lot Status**: Displays the current status of the parking lot, including the number of parked vehicles.
- **Dynamic Menu**: Provides an interactive console menu for user actions.

## How to Run
1. Clone the repository or download the source code.
2. Open the project in your favorite C# IDE (e.g., Visual Studio).
3. Build the project to ensure all dependencies are resolved.
4. Run the application from the IDE or using the command line.

## Usage
1. Launch the application.
2. Follow the menu prompts to interact with the parking system.
    - To park a vehicle, select the appropriate option and enter the required details.
    - To retrieve a vehicle, provide the license plate of the vehicle to be retrieved.
    - View the parking lot status to check the available slots and parked vehicles.
3. Exit the application when done.

## Example Output
```
=========================================
             PARKING LOT APP             
=========================================
1. Park
2. Leave
3. Status
4. Show Count of Vehicles by Type
5. Show Registration Numbers of Vehicles By Odd or Event Plate
6. Show Registration Numbers of Vehicles By Color
7. Show Slot Numbers for Vehicles By Color
8. Show Slot Number for Vehicle By Registration Number
9. Exit
Masukkan menu (1 - 9): 

```