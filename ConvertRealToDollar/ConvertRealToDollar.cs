/* Write a program that converts from real to dollar, 
 * using the dollar value as a constant.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task01
{
    public class ConvertRealToDollar
    {
        public static void Main() 
        { 
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR"); 
            double real = 0; 
            string result = ""; 
            const double DOLLAR = 5.06; 
            int attempts = 0; 
            double conversion = 0; 
            do 
            {
                if (attempts > 0) 
                {
                    Console.WriteLine("Value cannot contain letters or special characters."); 
                } 
                Console.WriteLine("Conversion from real to dollar.\nEnter an amount in real: ");
                result = Console.ReadLine();
                result = result.Replace(".", ",");
                attempts++; 
            } while (!result.Any(char.IsDigit)); 
            real = Convert.ToDouble(result);
            conversion = Math.Round((real / DOLLAR), 2); 
            Console.WriteLine($"The value of converting R${real} into dollars is US${conversion}."); 
        }
    }
}