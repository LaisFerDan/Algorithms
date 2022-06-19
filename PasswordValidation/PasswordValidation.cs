/* Request the full name, date of birth and a password.
 * Validate the password, it cannot contain name, surnames and/or date of birth.
 * Ask for a new password until it is valid.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task01
{
    public class PasswordValidation
    {
        public static void Main()
        {
            bool validName = true;
            string fullName = "";
            do
            {
                Console.WriteLine("Enter your full name:");
                fullName = Console.ReadLine();
                foreach (char letter in fullName)
                {
                    if (char.IsLetter(letter) || char.IsWhiteSpace(letter))
                    {
                        validName = true;
                    }
                    else
                    {
                        validName = false;
                        Console.WriteLine("Name cannot contain numbers or special characters.");
                        break;
                    }
                }
            } while (validName == false);

            string[] name = fullName.Split(" ");

            Console.Clear();

            static bool IsDateTime(string txtDate)
            {
                DateTime tempDate;
                return DateTime.TryParseExact(txtDate, "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out tempDate);
            }

            bool validDate = false;
            string birthDate = "";
            string[] date;
            while (validDate == false)
            {
                Console.WriteLine("Enter your date of birth (DD/MM/YYYY): ");
                birthDate = Console.ReadLine();
                var dataTime = IsDateTime(birthDate);
                foreach (char number in birthDate)
                {
                    if (dataTime == false)
                    {
                        Console.WriteLine("Date must be in DD/MM/YYY format and cannot contain letters or special characters.");
                        break;
                    }
                    validDate = true;
                }
            }
            date = birthDate.Split("/");

            Console.Clear();

            bool validPassword = false;
            int count = 0;
            string password = "";
            while (validPassword == false)
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < date.Length; j++)
                    {
                        if (password.Contains(date[j]) || password.Contains(name[i]))
                        {
                            count++;
                            Console.WriteLine("Password cannot contain first name, last name and/or date of birth.");
                            break;
                        }
                    }
                    if (count > 0)
                    {
                        break;
                    }
                }
                if (count == 0)
                {
                    validPassword = true;
                    Console.WriteLine("Password successfully accepted.");
                }
                count = 0;
            }
        }
    }
}
