using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter length");
            //int length = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter width");
            //int width = int.Parse(Console.ReadLine());
            //int area = length * width;
            //int Par = 15;
            //Console.WriteLine("Price per area = " + Par);
            //Console.ReadKey();
            //Console.WriteLine("You must pay = " + area * Par);


            //Console.WriteLine("Enter minute = ");
            //int amn = int.Parse(Console.ReadLine());

            //int amh = amn * 60;
            //Console.WriteLine("Amount per minute = {0} Amount per hour = {1}",amn,amh);
            
            
            Random rand = new Random();
            int RandNum = rand.Next(1,10);
           Console.WriteLine("Enter number = ");
            int KeyboardV = int.Parse(Console.ReadLine());
            Console.WriteLine("The random number is " + RandNum);
            if (KeyboardV > RandNum)
            {
                
                Console.WriteLine("high"); }

            else if (KeyboardV < RandNum)
            { Console.WriteLine("Low"); }
            else if (KeyboardV == RandNum)
            {
                Console.WriteLine("Correct");
                   }

        }
   
    }

}
