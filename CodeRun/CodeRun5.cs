using System;

class Program
{
    static void Main()
    {

        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine(0);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine(1);
            double root = -b / (2 * a);
            Console.WriteLine(root.ToString("F6"));
        }
        else
        {
            Console.WriteLine(2);
            double root1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            if (root1 > root2)
            {
                double temp = root1;
                root1 = root2;
                root2 = temp;
            }

            Console.WriteLine(root1.ToString("F6") + " " + root2.ToString("F6"));
        }
    }
}