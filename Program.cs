using System;
using GrowPlant.Models;

class Program
{
    private static Plant newPlant = new Plant ();
    private static string answer = "";

    private static void DisplayStats()
    {
        Console.WriteLine($"\nYour plant {newPlant.Name} is {newPlant.Height} inches tall. \n * Water Level: {newPlant.WaterLevel} \n * Foliage: {newPlant.Foliage} \n * Happiness: {newPlant.Happiness}");
    }

    private static void PromptUser()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Water | 2: Fertilize | 3: Give Sunshine | 4: Sing to It");
        Console.Write("\nYour Choice (1-4): ");
        GatherInput();
    }

    private static void GatherInput()
    {
        answer = Console.ReadLine();

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
                Console.WriteLine("Please enter a number between 1 and 4: ");
                GatherInput();
                break;
        }

        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        newPlant.RandomEvent();
        Console.ResetColor();
        NextSteps();
    }

    private static void NextSteps()
    {
        newPlant.DetermineAlive();

        if (newPlant.IsAlive)
        {
            DisplayStats();
            PromptUser();
        }
        else
        {
            Console.WriteLine($"\nSorry! {newPlant.Name} died!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n~~~GAME OVER~~~");
            Console.ResetColor();
            Console.Write("\nWould you like to play again? (Y/N): ");
            answer = Console.ReadLine();
            if(answer == "y" || answer == "Y")
            {
                newPlant.ResetPlant();
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
        }
    }

    private static void Main()
    {
        Console.Clear();
        Console.WriteLine("~~~GROW YOUR PLANT~~~");
        Console.WriteLine("Grow your plant taller by taking good care of it.");
        Console.WriteLine("\nTips:\n- Keep the water level between 0 and 7.\n- Keep it happy.");
        Console.Write("\nEnter a name for your new plant: ");
        answer = Console.ReadLine();
        newPlant.Name = answer;

        DisplayStats();
        PromptUser();
    }
}
