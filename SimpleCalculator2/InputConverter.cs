using System;
namespace SimpleCalculator2
{
    public class InputConverter
    {
      
            double numConverted;
            public double ConvertInputToNumber(string input)
            {



                if (!double.TryParse(input, out numConverted))
                {
                    throw new Exception("Conversion not successful");
                }

                return numConverted;
            }
        }
   
}
