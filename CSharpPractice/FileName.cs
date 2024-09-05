using System;
using System.Linq;

namespace RedGate
{
/*    class Program
    {
        static void Main(string[] args)
        {

        }

        static int CountEvenNumber(int[] input)
        {
            return input.Count(n => n % 2 == 0);
        }



        static int CountEvenNumber<T>(<T> input)
        {

            if (T typeof List<string>) {
                input = input.ToArray();
            }

            return input.Count(n => n % 2 == 0);
        }
    }*/

    class Program2
    {
        public int CountevenNumber(int[] input)
        {
            return input.Count(n => n % 2 == 0);
        }

        public int CountevenNumber(List<int> input)
        {
            int[] formattedInput = input.ToArray<int>();

            return this.CountevenNumber(formattedInput);
        }
}
}
