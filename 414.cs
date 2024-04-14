using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("words =");
            string str1 = Console.ReadLine();
   
           Console.WriteLine("x=");

            if (str1.Length > 50)
            {
                Console.WriteLine("請輸入50字以內");
                System.Environment.Exit(System.Environment.ExitCode);
            }
            string[] words = str1.Split(' ');

            char one = Console.ReadLine().ToLower()[0];
               
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].IndexOf(one) >= 0)
                    {
                        Console.WriteLine("["+i+"]");
                    }

                }
            }
           

            
    }
}
    
