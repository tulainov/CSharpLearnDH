namespace ClassesCode.FirstClass.exceptions;

public class Exceptions
{
     static double Divide(double a, double b)
     {
          if (b == 0)
          {
               throw new DivideByZeroException();
          }

          return a / b;
     }

     public static void RunExceptions()
     {

          double a = 5.0;
          double b = 0;
          double result;
          
          try
          {
               result = Divide(a, b);
               Console.WriteLine($"{a} / {b} = {result}");
          }
          catch (DivideByZeroException)
          {
               Console.WriteLine("Attempted to divide by 0!");
          }
     }
}