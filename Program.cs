using System;

namespace homePractice-Classes
{
    class Car
    {
    public Car()
    {
    }

    static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            

            // the reason you call 'myCar' in the console is because 'myCar' is the actual
            // instance of the class 'Car' is called 'myCar' and that's what we need to see
            Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Make, 
            myCar.Model, 
            myCar.Year, 
            myCar.Color);

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);

            Console.ReadLine();
          
        }
          private static decimal DetermineMarketValue(Car car)
          {
              decimal carValue = 100.0M;
                return carValue;

          }
}
