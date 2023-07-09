using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("calculate rectangle area");

        Console.Write("enter the length  ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("enter the width  ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("the rectangle area equals to " + area);
    }
}


    