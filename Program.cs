using System;
using GrowPlant.Models;

class Program
{
    public static Plant newPlant = new Plant ();

    private static void PromptUser()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Your plant {newPlant.Name} is {newPlant.Height} inches tall.");
        Console.WriteLine($"Water Level: {newPlant.WaterLevel}");
        Console.WriteLine($"Foliage: {newPlant.Foliage}");
        Console.WriteLine($"Happiness: {newPlant.Happiness}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Water, 2: Fertilize, 3: Give Sunshine, 4: Sing to It");
        string answer = Console.ReadLine();

        switch (answer)
        {
            case "1":
                newPlant.Water();
                break;
            case "2":
                newPlant.Fertilize();
                break;
            case "3":
                newPlant.Sunshine();
                break;
            case "4":
                newPlant.Sing();
                break;
            default:
                Console.WriteLine("Please enter a number between 1 and 4.");
                break;
        }
        if(newPlant.IsAlive())
        {
            PromptUser();
        }
        else
        {
            Console.WriteLine($"Sorry! {newPlant.Name} died!");
            Console.WriteLine("~~~GAME OVER~~~");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Would you like to play again?");
            string response = Console.ReadLine();
            if(response == "y" || response == "Y")
            {
                newPlant.ResetPlant();
                Main();
            }
            else
            {
                Console.WriteLine("Ok. Bye.");
            }

        }

    }

    private static void Main()
    {
        Console.WriteLine("~~~GROW YOUR PLANT~~~");
        Console.WriteLine("Enter a name for your new plant:");
        string answer = Console.ReadLine();
        newPlant.Name = answer;

        PromptUser();




    }
}
