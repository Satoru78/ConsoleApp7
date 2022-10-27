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
            ChekingPassword(password);

            Console.ReadKey();
         
        }
       public static string ChekingPassword(string pass)
            {
            if(pass.Length == 8)
            {
                if(pass.Any(char.IsLetter))
                {
                    if(pass.Any(char.IsDigit))
                    {
                        if(pass.Any(char.IsPunctuation))
                        {
                            if(pass.Any(char.IsSymbol))
                            {
                                if (pass.Any(char.IsLower))
                                {
                                    if (pass.Any(char.IsUpper))
                                    {
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Отсутвуют буквы нижнего регистра");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Отсутвуют буквы нижнего регистра");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Нет спец символов");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет знаков препинания");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Отсутсвуют цифры");
                    }
                }
                else
                {
                    Console.WriteLine("Отсутствуют буквы!");
                }
            }
            else
            {
                Console.WriteLine("Пароль корректный!");
            }
            return pass; 
            }
    }
}
