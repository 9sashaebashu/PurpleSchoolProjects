

using System;
using System.CodeDom;
using System.Globalization;

namespace The_System_of_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Типы и переменные
            Типы int, double; string; char; boolean; object; */

            const int consta = 10;
            int someValue = 1;
            int someValueAlpha = 3, someValueBeta = 5;

            Console.WriteLine(someValueAlpha);
            Console.WriteLine(someValueBeta);
            Console.WriteLine(someValue);
            Console.WriteLine(consta);

            /* Целочисленные типы:
                
               Основные целочисленные типы:
            sbyte, byte (8 бит)
            short, ushort (16 бит)
            int, uint (32 бит)
            long, ulong (64 бит)
            
               Особенности:
            uint: До 4 миллиардов.
            ulong: До 18 квинтиллионов.
            int128, uint128: Для 128-битовых чисел.
            BigInteger: Для произвольно больших чисел */

            /* Вещественные типы:
            
            float и double: используются в научных вычислениях и измерениях.
            decimal: подходит для финансовых расчетов благодаря точному представлению десятичных дробей */

            //  Преобразования

            byte byteValue = 10;
            
            short shortValue = 257; // Переполнение
            
            //checked 
            //{
            //    byteValue = (byte)shortValue; //Проверка на переполнение с checked
            //}
            
            Console.WriteLine(byteValue);

            //

            float floatValue = 10.3F;
            double doubleValue = 10000.2;

            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);

            doubleValue = floatValue;
            
            floatValue = (float)doubleValue;

            Console.WriteLine(doubleValue);
            Console.WriteLine(floatValue);

            // Арифметические операции

            int milleniumDigit = 2;
            int centuaryDigit = 0;
            int decadeDigit = 2;
            int yearDigit = 6;
            int year = (milleniumDigit * 1000) + (centuaryDigit * 100) + (decadeDigit * 10) + (yearDigit * 1);
            Console.WriteLine(year);
            
            // IMT Formula
            
            const int OneHundred = 100;
            const int Twenty = 20;
            var height = 1.8;

            int normalWeight = (int)(height * OneHundred - (OneHundred + (height * OneHundred - OneHundred) / Twenty));
            Console.WriteLine(normalWeight);

            // тип Char

            char symbol = 'Ы';
            char symbolChar = (char)1067;
            Console.WriteLine(symbol);
            Console.WriteLine(symbolChar);

            symbol = 'Р';
            symbol = (char)(symbol + 2);
            Console.WriteLine(symbol);

            // Введение в объекты

            double infinity = double.PositiveInfinity;

            Console.WriteLine(infinity);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            // Строки

            string stringValue = "I wanna fuck u :)";
            var letter = stringValue[4];
            
            int length = stringValue.Length;
            stringValue = "I DONT want\nto fuck u! :)";
            
            Console.WriteLine(stringValue);
            Console.WriteLine(letter);
            Console.WriteLine(length);

            string dick = "diCk";
            string stringValueAlpha = $"Don't touch my {dick}," + " dirty bitch! :)";
            Console.WriteLine(stringValueAlpha);

            Console.WriteLine("\nУпражнение ДЗ с символами: \n");

            char bigLetter = 'Я';
            char smallLetter = 'z';
            int value1 = 0x3A6;
            ushort value2 = '\u0824';
            long value3 = 10574;
            int value4 = '\x25A3';

            var mainChar = (char)value2;
            Console.WriteLine(mainChar);
            Console.WriteLine(char.GetUnicodeCategory(mainChar));

            char lowerChar = char.ToLower(bigLetter);
            Console.WriteLine(lowerChar);

            char higherChar = char.ToUpper(smallLetter);
            Console.WriteLine(higherChar);

            Console.WriteLine("\nУпражнение ДЗ со строками: \n");

            string first = "Меня ";
            string second = "зовут ";
            string third = Console.ReadLine();

            string fullString = $"{first}\n{second}\n{third}!";
            Console.WriteLine(fullString);



        }
    }
}
