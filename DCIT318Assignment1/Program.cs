using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==== DCIT 318 Assignment Menu ====");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GradeCalculator();
                    break;
                case "2":
                    TicketPriceCalculator();
                    break;
                case "3":
                    TriangleTypeIdentifier();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
    static void GradeCalculator()
    {
        Console.Write("Enter numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 90) Console.WriteLine("Grade: A");
            else if (grade >= 80) Console.WriteLine("Grade: B");
            else if (grade >= 70) Console.WriteLine("Grade: C");
            else if (grade >= 60) Console.WriteLine("Grade: D");
            else Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }


