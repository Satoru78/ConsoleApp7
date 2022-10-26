using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль:");
            string password = Convert.ToString(Console.ReadLine());
            if()
            {

                
            }
            else
            {
                Console.WriteLine("Повторите попытку!");
            }
        }
            public string ChekingPassword()
            {
              
                 bool CheckPass(string pass) => pass.Length >= 6
                 && pass.Any(char.IsLetter)
                 && pass.Any(char.IsDigit)
                 && pass.Any(char.IsPunctuation)
                 && pass.Any(char.IsLower)
                 && pass.Any(char.IsUpper);

               Console.WriteLine(CheckPass("Qwerty123"));
               Console.WriteLine(CheckPass("Qwerty123!"));

            return pass; 
            }
    }
}
