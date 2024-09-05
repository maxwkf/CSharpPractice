using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Note
    {
        public Note()
        {
        }

        public static void ErrorHandling()
        {
            bool looping = true;
            while (looping)
            {
                try
                {
                    Console.Write("Please enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"The numnber is {num}. Goodbye");
                    looping = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }



        }


        public static void TestOptionalParameter(int a, int b = default)
        {
            Console.WriteLine(a + b);
        }

        public static void TestPassByReference(ref int num)
        {
            num *= 2;
        }
        public static void TestOutParameters()
        {
            bool result = _testOutParameters(12, out int thenum);

            Console.WriteLine(result);
            Console.WriteLine(thenum);
        }

        private static bool _testOutParameters(int inputNumber, out int outputNumber)
        {

            outputNumber = inputNumber * 2;
            return true;

        }


        public static void TestNamedParameters()
        {
            Note._testNamedParameters(param2: 1, param1: "input");
        }

        private static void _testNamedParameters(string param1, int param2)
        {
            // do nothing
        }


        public static void TestArraySorting()
        {
            int[] numArray = new int[] { 9, 33, 1, 56, 4, 23, 57 };

            Array.Sort(numArray);

            foreach (int num in numArray)
            {
                Console.Write(num + " ");
            }
        }

        public static void TestMultithreading()
        {
            (new Multithreading()).Run();
        }

        public static void TestSleep()
        {
            string original = "This is a testing";
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i]);
                Thread.Sleep(100);
            }
        }

        public static void TestStringCompare()
        {
            string original = "Hello";
            string compare = "Hello";

            Console.WriteLine("Comparing string original = \"Hello\" to string compare = \"Hello\"");
            Console.Write("Result(using ==): ");
            if (original == compare)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }

            char[] helloArray = { 'H', 'e', 'l', 'l', 'o' };
            object stringObject = new String(helloArray);

            Console.WriteLine();
            Console.WriteLine("string original = \"Hello\" to object type new String({ 'H', 'e', 'l', 'l', 'o' })");
            Console.Write("Result(using ==): ");
            if (original == stringObject)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }

            Console.Write("Result(using Equals): ");
            if (original.Equals(stringObject))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }

            Console.WriteLine("Using 'Equals' checks the literal value inside variable instead of checking value held in memory location.");
            Console.WriteLine("Using '==' compares the string object with and object.");
            Console.WriteLine("So, it would better use .Equals");
        }

        public static void TestNumberFormatting()
        {
            Note.NumberFormatting();
        }

        public static void CheckNullOrEmpty()
        {
            string original = null;
            if (string.IsNullOrWhiteSpace(original))
            {
                Console.WriteLine("This is empty");
            }
        }

        public static void CheckSubstring()
        {
            string original = "This is a testing";
            string substring = "testing";
            if (original.Contains(substring))
            {
                Console.WriteLine($"Found {substring}");
            }
            else
            {
                Console.WriteLine($"{substring} NOT found");
            }
        }

        public static void NumberFormatting()
        {
            double cost = 22D / 7D;

            Console.WriteLine(string.Format("£{0:0.00} ${1:0.000}", cost, 200.12345));  //£3.14 $200.123

        }

        public static void ReadFromCommandLine()
        {
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        public static void CreateDifferentNumberType()
        {

            int num = 100;

            long lon = 100L;

            float flo = 100.22F;

            double dou = 100D;

            decimal dec = 100.12M;

        }

        public static void ConvertTextToNumber()
        {
            string textNum = "-23";

            int num = Convert.ToInt32(textNum);

        }
    }
}
