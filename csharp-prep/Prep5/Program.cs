using System;

class Program
{
    static void Main(string[] args)
    {
           List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Green", 5, 10);
        shapes.Add(s2);

        Circle s3 = new Circle("Blue", 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            string sType = s.GetShapeType();

            Console.WriteLine($"The {sType} is {color} and has an area of {area}.");
        }
    }
    //     DisplayWelcome();

    //     string userName = PromptUserName();
    //     int userNumber = PromptUserNumber();

    //     int squaredNumber = SquareNumber(userNumber);

    //     DisplayResult(userName, squaredNumber);
    // }
    
    // static void DisplayWelcome()
    // {
    //     Console.WriteLine("Welcome to the Program!");
    // }

    // static string PromptUserName()
    // {
    //     Console.WriteLine($"Please enter your name: ");
    //     string userName = Console.ReadLine();

    //     return userName;
    // }

    // static int PromptUserNumber()
    // {
    //     Console.WriteLine($"Please enter your favorite number: ");
    //     int userNumber = int.Parse(Console.ReadLine());

    //     return userNumber;
    // }

    // static int SquareNumber(int number)
    // {
    //     int square = number * number;
    //     return square;
    // }

    // static void DisplayResult(string userName, int square)
    // {
    //     Console.WriteLine($"{userName}, the square of your number is {square}");
    // }
}