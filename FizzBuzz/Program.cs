using System;
namespace FizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            int maxNumber;
            if(args.Length==0)
            {
                maxNumber = 100;
            }
            else
            {
                maxNumber = int.Parse(args[0]);
            }

           Fizzbuzz fizzbuzz1 = new Fizzbuzz();
           fizzbuzz1.DoFizzBuzz(maxNumber);
        }
    }
}
