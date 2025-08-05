using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("Movie Ticket Price Calculator");
        Console.WriteLine("---------------------------");
        
        const decimal STANDARD_PRICE = 10.00m;
        const decimal DISCOUNTED_PRICE = 7.00m;
        
        while (true)
        {
            Console.Write("\nEnter your age (or 'q' to quit): ");
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input?.ToLower() == "q")
                break;
                
            // Validate input
            if (!int.TryParse(input, out int age) || age <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for age.");
                continue;
            }
            
            // Calculate ticket price
            decimal price = (age <= 12 || age >= 65) ? DISCOUNTED_PRICE : STANDARD_PRICE;
            string ticketType = (age <= 12) ? "Child" : (age >= 65 ? "Senior Citizen" : "Standard");
            
            // Display result
            Console.WriteLine($"\nTicket Type: {ticketType}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Ticket Price: GHC{price:F2}");
            Console.WriteLine($"You {(price == DISCOUNTED_PRICE ? "qualify" : "do not qualify")} for the discounted price.");
        }
        
        Console.WriteLine("\nThank you for using the Ticket Price Calculator!");
    }
}
