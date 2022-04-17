using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Hello World!");
            
            int numberpositive = 2147483647; //MAX Value 32bit 
            int numbernegative = -214748348; // Max Negative Value 32 bit 
            long number = 9223372036854775807; //Max value 64 bit
            long number2 = -9223372036854775808; // Max Negative value 64 bit
            short number3 = 32767; //Max value 16bit
            short number4 = -32768; //Max Negative value 16bit
            byte number5 = 0;  //Min value 1 byte = 8 bit
            byte number6 = 255; // Max value 1 byte = 8 bit
            char character = 'A'; // İts about ASCII table 
            bool condition = false; // True or False
            double number7 = 11.1; // Decimal Numbers and 64 bit
            decimal number8 = 11.117m; //Same thinks like double but more complicated
            var number9 = 11;
            number9 = 'A'; // its show A number on ascıı table 
            Console.WriteLine("Numberpozitif  is {0} Numbernegative  is {1}",numberpositive,numbernegative);
            Console.WriteLine("Number Long pozitif  is {0} Number Long negative  is {1}", number, number2);
            Console.WriteLine("Number Short pozitif  is {0} Number Short negative  is {1}", number3, number4);
            Console.WriteLine("Number byte Min is {0} Number byte Max   is {1}", number5, number6);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character ASCİİ number is  : {0}", (int)character);
            Console.WriteLine("Character is : {0}", number7);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number9 is {0}", number9);
            Console.ReadLine();
        }
    }
    enum Days // Magic 
    {
        Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday

    }
}
