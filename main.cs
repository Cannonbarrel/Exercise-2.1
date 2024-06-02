using System;

class Program {
  public static void Main (string[] args) {
            
            const double CentimetersInInch = 2.54;
            double inches = 5; 

            double centimeters = inches * CentimetersInInch;

            Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);
        }
    }
