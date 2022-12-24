using System;
namespace ThePrimeNumbers ;
public class program
{
    public static void Main(string[]args)
    {
        int x, y, z, first, second;
        Console.Write("Enter Starting Number of range: ");
        first = int.Parse(Console.ReadLine());
        Console.Write("Enter Ending Number of range : ");
        second = int.Parse(Console.ReadLine());
        Console.WriteLine("The prime numbers between {0} and {1} are :", first, second);
        for (x = first; x <= second; x++)
        {
         z = 0;
         for (y = 2 ; y <= x / 2; y++)
         {
          if (x % y == 0)
           {
            z++;
            break;
          }
         }
          if (z == 0 && x != 1)
          Console.Write("{0} ", x);
        }
      
    }
}

