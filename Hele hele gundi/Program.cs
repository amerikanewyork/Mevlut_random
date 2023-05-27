using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hele_hele_gundi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(1,101);
            bool foundNumber = false;

            Console.WriteLine("1,101 kadar tahmin edelim fast şekilde.");

            if (!foundNumber)
            {
                Console.WriteLine("Tahmininizi girin: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)
                {
                    Console.WriteLine("bir Random sayı giriniz.");
                }
                else if (guess < randomNumber)
                {

                    Console.WriteLine("Bir sayı tutuldu.");
                }
                else guess = randomNumber;
                {
                    Console.WriteLine("Hata adamın!!");
                    foundNumber = true;
                }




            }






            Console.ReadLine();


                }
    }
}
