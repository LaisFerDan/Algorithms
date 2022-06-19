/* Create a program that receives a formatted CPF/CNPJ. 
 * Remove the formatting and display only the numbers on the screen.
 * 
 * CPF (Cadastro de Pessoas Físicas; Portuguese for "Natural Persons Register")
 * is the Brazilian individual taxpayer registry identification. 
 * This number is attributed by the Brazilian Federal Revenue to Brazilians 
 * and resident aliens who, directly or indirectly, pay taxes in Brazil. 
 * It's an 11-digit number in the format 000.000.000-00.
 * 
 * CNPJ (Cadastro Nacional de Pessoas Jurídicas; 
 * Portuguese for "Brazilian National Registry of Legal Entities") 
 * is a nationwide registry of corporations, partnerships, foundations, 
 * investment funds, and other legal entities, created and maintained by 
 * the Brazilian Federal Revenue Service. Currently, all companies are 
 * automatically enrolled in the system upon incorporation. 
 * The system uses a fourteen-digit number, which is made up of 
 * an eight-digit unique identifier, a four-digit branch identifier, 
 * and two check digits, in the format 00.000.000/0000-00.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class CPForCNPJOnlyNumbers
    {
        public static void Main()
        {
            const string INVALID_DATA = "Invalid data, enter numeric values up to 14 digits only."; 
            string data = ""; 
            double unformattedData = 0; 
            int attempts = 0; 
            do 
            {
                if (attempts > 0) 
                { 
                    Console.WriteLine(INVALID_DATA); 
                } 
                Console.WriteLine("Enter a CPF/CNPJ: ");
                data = Console.ReadLine();
                data = data.Replace(".", "");
                data = data.Replace("/", "");
                data = data.Replace("-", "");
                attempts++; 
            } while (double.TryParse(data, out unformattedData) == false || data.Length > 14);
            Console.WriteLine(data.Length <= 11 ? data.PadLeft(11, '0') : data.PadLeft(14, '0'));
        }
    }
}
