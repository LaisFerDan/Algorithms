/* Create a program that receives a numeric-only CPF/CNPJ. 
 * From the value read, identify whether this value fits a CPF or a CNPJ. 
 * Perform formatting by adding special characters and display on screen.
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
    public class FormattedCPForCNPJ
    {
        public static void Main() 
        { 
            string data = ""; 
            int attempts = 0; 
            double verifyData = 0;
            do
            { 
                if (attempts > 0) 
                { 
                    Console.WriteLine("Invalid data, enter numeric values up to 14 digits only."); 
                } 
                Console.WriteLine("Enter only the numerical values of a CPF/CNPJ: ");
                data = Console.ReadLine();
                attempts++; 
                Console.Clear(); 
            } while (double.TryParse(data, out verifyData) == false || data.Contains(".") || data.Length > 14 || data.Contains(",")); 
            if (data.Length <= 11) 
            {
                data = data.PadLeft(11, '0');
                data = data.Insert(3, ".");
                data = data.Insert(7, ".");
                data = data.Insert(11, "-");
                Console.WriteLine($"CPF with formatting: {data}");
            } 
            else
            {
                data = data.PadLeft(14, '0');
                data = data.Insert(2, ".");
                data = data.Insert(6, ".");
                data = data.Insert(10, "/");
                data = data.Insert(15, "-");
                Console.WriteLine($"CNPJ with formatting: {data}");
            } 
        }
    }
}