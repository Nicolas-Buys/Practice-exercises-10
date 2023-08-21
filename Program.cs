using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_exercises
{
    internal class Program
    {   
        enum Menu
        {
            Q1 = 1,
            Q2 = 2,
            Q3 = 3,
            Q4 = 4,
            Q5 = 5,
            Q6 = 6,
            Q7 = 7,
            Q8 = 8,
            Q9 = 9,
            Q10 = 10
        }
        enum Shape
        {
            Circle =1, 
            Rectangle, 
            Triangle
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                for (int i = 1; i <11; i++)
                {
                    Console.WriteLine(i.ToString()+". "+(Menu)i); 
                }
                int choice = int.Parse(Console.ReadLine());
                switch ((Menu)choice)
                {
                    case Menu.Q1:
                        for (int i = 1; i <=40; i++)
                        {
                            int multiple = i * 5;
                            Console.WriteLine( multiple);
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q2:
                        Console.WriteLine("Enter a word: ");
                        string word = Console.ReadLine();
                        for (int i = 0; i < word.Length; i++)
                        {
                            Console.WriteLine(word[i]);
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q3:
                        int[] arrnum = { 2, 5, 7, 3, 4, 3 };
                        for (int i = arrnum.Length -1; i >=0 ; i--)
                        {
                            Console.WriteLine(arrnum[i]);

                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q4:
                        int[] arroddeven = { 1, 4, 7, 18, 5, 9, 23, 56, 17 };
                        List<int> even = new List<int>();
                        List<int> odd = new List<int>();
                        int[] oddarray;
                        int[] evenarray;
                        for (int i = 0; i < arroddeven.Length; i++)
                        {
                            if (arroddeven[i] % 2 == 0)
                            {
                                even.Add(arroddeven[i]);
                            }
                            else
                            {
                                odd.Add(arroddeven[i]); 
                            }
                        }
                        oddarray = odd.ToArray();
                        evenarray = even.ToArray();
                        Console.WriteLine("\nOriginal\n");
                        foreach ( int num in arroddeven)
                        {
                            Console.Write(num +", ");
                        }
                        Console.WriteLine("\nOdd\n");
                        foreach (int num in odd)
                        {
                            Console.Write(num + ", ");
                        }
                        Console.WriteLine("\nEvenl\n");
                        foreach (int num in even)
                        {
                            Console.Write(num + ", ");
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q5:
                        Console.WriteLine("Enter a cellphone number");
                        string cellnum = Console.ReadLine();
                        bool check = Checknumber(cellnum);
                        if (check == true)
                        {
                            Console.WriteLine("Correct");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Must be 10 digits");
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q6:
                        Console.WriteLine("Enter number");
                        int numcheck = int.Parse(Console.ReadLine());
                        EvenOdd(numcheck);
                        Prime(numcheck);
                        Factors(numcheck);
                        Console.ReadKey();
                        break;
                    case Menu.Q7:
                        int[] calc = new int[10];
                        for (int i = 0; i < calc.Length; i++)
                        {
                            Console.WriteLine("Enter number {0} of {1}: ",i+1, calc.Length);
                            calc[i] = int.Parse(Console.ReadLine());
                        }
                        Min(calc);
                        Ave(calc);
                        Max(calc);
                        Sum(calc);
                        Console.ReadKey();
                        break;
                    case Menu.Q8:
                        Console.WriteLine("Enter Salary");
                        int sal = int.Parse(Console.ReadLine());
                        if (sal < 5000)
                        {
                            Console.WriteLine( "Tax is 0%");
                        }
                        else if(sal>= 5000 && sal < 15000)
                        {
                            Console.WriteLine("Tax is 4%");
                        }
                        else if (sal >= 15000 && sal < 25000)
                        {
                            Console.WriteLine("Tax is 6%");
                        }
                        else if (sal >= 25000)
                        {
                            Console.WriteLine("Tax is 8%");
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Q9:
                        int num1, num2 = 0;
                        Console.WriteLine(  "Enter a number: ");
                        num1 = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Guess the number");
                            num2 = int.Parse(Console.ReadLine());
                            if (num2 > num1)
                            {
                                Console.WriteLine("Number is too big");
                            }
                            else if (num2 < num1)
                            {
                                Console.WriteLine("Number is too small");
                            }
                            else if (num2 == num1)
                            {
                                Console.WriteLine("Number is correct");
                            }
                        }
                        while (num1 != num2);
                        Console.ReadKey();
                        break;
                    case Menu.Q10:
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i.ToString() + ". " + (Shape)i);
                        }
                        int shapechoice = int.Parse(Console.ReadLine());
                        switch ((Shape)shapechoice)
                        {
                            case Shape.Circle:
                                Console.WriteLine("enter radius: ");
                                double radius = double.Parse(Console.ReadLine());
                                Circle circle = new Circle(radius);
                                Console.WriteLine("Area = {0}", circle.Area());
                                break;
                            case Shape.Rectangle:
                                Console.WriteLine("enter width: ");
                                double width = double.Parse(Console.ReadLine());
                                Console.WriteLine("enter height: ");
                                double height = double.Parse(Console.ReadLine());
                                Rectangle rectangle = new Rectangle(width, height); 
                                Console.WriteLine("Area = {0}", rectangle.Area());
                                break;
                            case Shape.Triangle:
                                Console.WriteLine("enter bae: ");
                                double baseh = double.Parse(Console.ReadLine());
                                Console.WriteLine("enter height: ");
                                double heightt = double.Parse(Console.ReadLine());
                                Triangle triangle = new Triangle(baseh, heightt); 
                                Console.WriteLine("Area = {0}", triangle.Area());
                                break;
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }
        static bool Checknumber(string num)
        {
            if (num.Length == 10)
            {
                return true;
            }
            else { return false; }
        }
        static void EvenOdd(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else { Console.WriteLine("Odd"); }
        }
        static void Prime(int num)
        {
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    isprime = false; break;
                }
            }
            if(isprime == true)
            {
                Console.WriteLine("Number {0} is a prime number", num);
            }
            else
            {
                Console.WriteLine("Number {0} is not a prime number", num);
            }
        }
        static void Factors(int num)
        {
            Console.WriteLine("Factors of {0}: ", num);
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Max(int[] numbers)
        {
            Console.WriteLine("Max value is {0}", numbers.Max());
        }
        static void Min(int[] numbers)
        {
            Console.WriteLine("Min value is {0}", numbers.Min());
        }
        static void Ave(int[] numbers)
        {
            Console.WriteLine("Average is {0}", numbers.Average());
        }
        static void Sum(int[] numbers)
        {
            Console.WriteLine("Sum is {0}", numbers.Sum());
        }
    }
}