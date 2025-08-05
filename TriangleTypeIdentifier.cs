using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("----------------------");
        
        while (true)
        {
            Console.WriteLine("\nEnter the lengths of the three sides of the triangle (or 'q' to quit):");
            
            // Get and validate first side
            Console.Write("Side 1: ");
            string input1 = Console.ReadLine();
            if (input1?.ToLower() == "q") break;
            if (!double.TryParse(input1, out double side1) || side1 <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for side 1.");
                continue;
            }
            
            // Get and validate second side
            Console.Write("Side 2: ");
            string input2 = Console.ReadLine();
            if (input2?.ToLower() == "q") break;
            if (!double.TryParse(input2, out double side2) || side2 <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for side 2.");
                continue;
            }
            
            // Get and validate third side
            Console.Write("Side 3: ");
            string input3 = Console.ReadLine();
            if (input3?.ToLower() == "q") break;
            if (!double.TryParse(input3, out double side3) || side3 <= 0)
            {
                Console.WriteLine("Please enter a valid positive number for side 3.");
                continue;
            }
            
            // Check if the sides form a valid triangle
            if (!IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine("These sides do not form a valid triangle. The sum of any two sides must be greater than the third side.");
                continue;
            }
            
            // Determine and display the triangle type
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"\nTriangle with sides {side1}, {side2}, and {side3} is: {triangleType}");
        }
        
        Console.WriteLine("\nThank you for using the Triangle Type Identifier!");
    }
    
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    
    static string DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Equilateral (all sides equal)";
            
        if (a == b || b == c || a == c)
            return "Isosceles (two sides equal)";
            
        return "Scalene (no sides equal)";
    }
}
