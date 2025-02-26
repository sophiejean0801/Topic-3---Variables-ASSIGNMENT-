namespace Topic_3___Variables_ASSIGNMENT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Part 1
            int roomNumber, gradYear, radius;
            string courseName, name;
            double price, pi, area1, roundedPi;

            roomNumber = 29;
            courseName = "Computer Science";
            price = 2.99;

            Console.WriteLine("This is room " + roomNumber);
            Console.WriteLine("I am learning about " + courseName);
            Console.WriteLine("The price is " + price);

            // Part 2
            gradYear = 2026;
            name = "Sophie Jean";

            Console.WriteLine("My name is " + name + " and I graduate in " + gradYear);

            //Part 3
            radius = 5;
            pi = 3.14159;
            roundedPi = Math.Round(pi, 1); //rounds pi to 1 decimal place
            area1 = (radius * radius * pi);
            Console.WriteLine("The area of a circle with a radius of " + radius + " is " + area1);

            //Part 4
            int area2, length, width;
            length = 10;
            width = 5;
            area2 = length * width;
            Console.WriteLine("The area of a rectangle with a length of " + length + " and a width of " + width + " is " + area2);
        }
    }
}
