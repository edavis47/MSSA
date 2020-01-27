using System;

public class Class1
{
	public Class1()
	{
        //Add 10 numbers
        Console.WriteLine("Enter 10 numbers between 0-100:");
        int num0 = int.Parse(Console.ReadLine());
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());
        int num6 = int.Parse(Console.ReadLine());
        int num7 = int.Parse(Console.ReadLine());
        int num8 = int.Parse(Console.ReadLine());
        int num9 = int.Parse(Console.ReadLine());

        int sum = num0 + num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
        Console.WriteLine($"Sum: {sum.ToString()}");
    }
}
