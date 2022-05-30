using System;

namespace FizzBuzz
{
   public class Fizzbuzz
   {
       private bool IsDivisibleBy(int numerator , int denominator)
       {
           return numerator % denominator == 0;
       }
       private bool StartWithB(string testString)
       {
           return testString[0] == 'B';
       }
      public void DoFizzBuzz(int maxNumber)
      {
          for(int i=1; i<=maxNumber ; i++)
          {
              Console.WriteLine(ForNumber(i));
          }
      }
      public string ForNumber(int number)
      {
            List<string> result =new List<string>();
            if(IsDivisibleBy(number,3))
            {
                result.Add("Fizz");
            }
             if(IsDivisibleBy(number,5))
            {
                result.Add("Buzz");
            }
            if(IsDivisibleBy(number,7))
            {
                result.Add("Bang");
            }
            if(IsDivisibleBy(number,11))
            {
                result = new List<string>(){"Bong"};
            }
            if(IsDivisibleBy(number,13))
            {
               int firstBIndex = result.FindIndex(StartWithB);
               if(firstBIndex == -1)
               {
                   result.Add("Fezz");
               }
               else
               {
                   result.Insert(firstBIndex,"Fezz");
               }  
            }
            if(result.Count==0)
            {
                return number.ToString();
            }
            else
            {
                return string.Join("",result);
            }
      }
      }
   }