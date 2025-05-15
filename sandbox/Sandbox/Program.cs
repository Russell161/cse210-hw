// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello Sandbox World!");
//         Console.Write("Please insert your first name: ");
//         string firstname = Console.ReadLine();
//         Console.Write("Please insert your last name: ");
//         string lastname = Console.ReadLine();
//         Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

//     }
// }

// using System;
// using System.Security.Cryptography.X509Certificates;
// // using System.Configuration.Assemblies;
// // using System.Runtime.CompilerServices;
// // using System.Security.Cryptography.X509Certificates;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("What is your grade percentage? ");
//         string grade = Console.ReadLine();
//         int percent = int.Parse(grade);

//         string letter = "";
        
//         if (percent >= 90)
//         {
//             letter = "A";
//         }
//         else if (percent >= 80)
//         {
//             letter = "B";
//         }
//         else if (percent >= 70)
//         {
//             letter = "C";
//         }
//         else if (percent >= 60)
//         {
//             letter = "D";
//         }
//         else
//         {
//             letter = "F";
//         }

//         Console.WriteLine($"Your grade is: {letter}");

//        if (percent >= 70)
//         {
//             Console.WriteLine("You passed!");
//         }
//         else
//         {
//             Console.WriteLine("Better luck next time!");
//         }
//     }
// }    

// int x = 10;
// if (x == 10)
// {
//     Console.WriteLine("x is 10");
// }

// for(int i = 0; i < x; i++)


// {
//     Console.WriteLine($"Bob is Cool: {i}");
// }
// // testing
// // testing pt 2

using System;
using System.Diagnostics.Tracing;
using System.Net.NetworkInformation;

class Circle
{
    private double _radius;

    public void SetRadius(double radius)
    {
        if(radius < 0)
        {
            Console.WriteLine("Error");
            return;
        }
        _radius = radius;
    }
        public double GetRadius()
    {
        return _radius;

    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

class Program
{
    static void Main(string[] args)

    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Circle myCircle2 = new Circle();
        myCircle.SetRadius(20);

        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle2.GetRadius()}");

        Console.WriteLine($"{myCircle.GetArea()}");
        
    }
}