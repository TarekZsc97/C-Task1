using System;

class PrintName
{
    static void Main()
    {
        Console.WriteLine("Hello:");
        Console.WriteLine("Hussain");
    }
}



class Average
{
    static void Main()
    {
        Console.WriteLine("Enter four numbers:");

        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4;

        Console.WriteLine("The average is: " + average);
    }
}



class Swabnum
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);
    }
}



class FirstNum
{
    static void Main()
    {
        Console.WriteLine("Input the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
    }
}



class Age
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You look older than " + age);
    }
}


class Even
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an even integer");
        }
        else
        {
            Console.WriteLine(num + " is an odd integer");
        }
    }
}




class Natural
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("The first 10 natural number is :");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine("\nThe Sum is : " + sum);
    }
}




class LargestNumb
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }

        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
}



class Cub
{
    static void Main()
    {
        Console.WriteLine("Input number of terms:");
        int terms = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= terms; i++)
        {
            int cube = i * i * i;
            Console.WriteLine("Number is : " + i + " and cube of the " + i + " is : " + cube);
        }
    }
}



class Terms
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        Console.WriteLine("The first " + n + " natural numbers are:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine("\nThe Sum is : " + sum);
    }
}





















