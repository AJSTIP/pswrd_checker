using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pswrd_checker
{
    class Program
    {
        static void Main(string[] args)
        {
                int minLength = 8;
                string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string lowercase = "abcdefghijklmnopqrstuvwxyz";
                string digits = "0123456789";
                string specialChars = "#?!,-'/`_*$";
                Console.WriteLine("Please Enter A Password to have Checked: ");
                string password = Console.ReadLine();
                int score = 0;
                if ((score) >= (minLength))
                {
                    score++;
                }

                if (password, uppercase)
                {
                    score++;
                }

                if (password, lowercase)
                {
                    score++;
                }

                if (password, digits)
                {
                    score++;
                }

                if (password, specialChars)
                {
                    score++;
                }

                Console.WriteLine("The password you entered: " + password);
                Console.WriteLine("Your score is: " + score);

                switch (score)
                {
                    case 5:
                    case 4:
                        Console.WriteLine("This is an extremely strong password");
                        break;
                    case 3:
                        Console.WriteLine("This is a strong password");
                        break;
                    case 2:
                        Console.WriteLine("This is an average password");
                        break;
                    case 1:
                        Console.WriteLine("This is a weak password");
                        break;
                    default:
                        Console.WriteLine("This password doesn't meet the standards");
                        break;
                }
                Console.ReadLine();
            }
        }
    }