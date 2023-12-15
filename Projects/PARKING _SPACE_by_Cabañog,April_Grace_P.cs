using System;

class ParkingSpaceManager
{
    static void Main()
    {
        int numberOfSpaces = 10;
        bool[] parkingSpaces = new bool[numberOfSpaces];

        InitializeParkingSpaces(parkingSpaces);
        DisplayMenu(parkingSpaces);
    }

    static void InitializeParkingSpaces(bool[] spaces)
    {
        for (int i = 0; i < spaces.Length; i++)
        {
            spaces[i] = false; // Initially, all spaces are available
        }
    }

    static void DisplayMenu(bool[] parkingSpaces)
    {
        while (true)
        {
            Console.WriteLine("\n1. View Parking Spaces");
            Console.WriteLine("2. Park Car");
            Console.WriteLine("3. Leave Parking Space");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewParkingSpaces(parkingSpaces);
                    break;
                case 2:
                    ParkCar(parkingSpaces);
                    break;
                case 3:
                    LeaveParkingSpace(parkingSpaces);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ViewParkingSpaces(bool[] spaces)
    {
        Console.WriteLine("\nParking Spaces:");

        for (int i = 0; i < spaces.Length; i++)
        {
            Console.WriteLine($"Space {i + 1}: {(spaces[i] ? "Occupied" : "Available")}");
        }
    }

    static void ParkCar(bool[] spaces)
    {
        Console.Write("\nEnter the parking space number: ");
        int spaceNumber = int.Parse(Console.ReadLine());

        if (IsValidSpace(spaceNumber, spaces.Length) && !spaces[spaceNumber - 1])
        {
            spaces[spaceNumber - 1] = true;
            Console.WriteLine($"Car parked in space {spaceNumber}.");
        }
        else if (!IsValidSpace(spaceNumber, spaces.Length))
        {
            Console.WriteLine("Invalid space number. Please try again.");
        }
        else
        {
            Console.WriteLine($"Space {spaceNumber} is already occupied.");
        }
    }

    static void LeaveParkingSpace(bool[] spaces)
    {
        Console.Write("\nEnter the parking space number: ");
        int spaceNumber = int.Parse(Console.ReadLine());

        if (IsValidSpace(spaceNumber, spaces.Length) && spaces[spaceNumber - 1])
        {
            spaces[spaceNumber - 1] = false;
            Console.WriteLine($"Car left space {spaceNumber}.");
        }
        else if (!IsValidSpace(spaceNumber, spaces.Length))
        {
            Console.WriteLine("Invalid space number. Please try again.");
        }
        else
        {
            Console.WriteLine($"Space {spaceNumber} is already vacant.");
        }
    }

    static bool IsValidSpace(int spaceNumber, int totalSpaces)
    {
        return spaceNumber >= 1 && spaceNumber <= totalSpaces;
    }
}
