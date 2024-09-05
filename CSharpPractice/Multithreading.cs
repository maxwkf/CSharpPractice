using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{

    internal class PrintCharacter
    {
        public string input;
        public int speed;
        public PrintCharacter(string input, int speed)
        {
            this.input = input;
            this.speed = speed;
        }

        public void Print()
        {

            Console.WriteLine($"Start to print out {this.input}");
            for (int i = 0; i < this.input.Length; i++)
            {
                // Print out the current character
                Console.Write(this.input[i]);

                // Sleep for a short period
                Thread.Sleep(this.speed);
            }
            Console.WriteLine();
            Console.WriteLine($"End of printing {this.input}");
        }
    }

    internal class Multithreading
    {
        public Multithreading()
        {

        }

        public void Run()
        {

            string[] inputArray = { 
                "The world is so good",
                "I would like to have more money to rest"
            };

            int[] speedArray =
            {
                536, 237
            };

            for(int i = 0; i < inputArray.Length; i++)
            {
                PrintCharacter printCharacter = new PrintCharacter(inputArray[i], speedArray[i]);

                // create a main thread to 
                ThreadStart ts = new ThreadStart(printCharacter.Print);
                Thread myThread = new Thread(ts);
                myThread.Start();
            }

        }

        public static void PrintCharacters(string input)
        {
        }
    }
}
