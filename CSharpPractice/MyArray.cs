using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{

    internal class MyArray<InputArrayType>
    {
        public InputArrayType[] inputArray {get; set;}
        public MyArray(InputArrayType[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public InputArrayType[] getReversedArray()
        {
            int length = this.inputArray.Length;
            InputArrayType[] result = new InputArrayType[length];

            for( int i = 0; i < length; i++)
            {
                result[i] = this.inputArray[length - 1 -i];
            }

            return result;

        }

        public InputArrayType[] getReversedArray2()
        {
            InputArrayType[] reversedArray = this.inputArray;
            Array.Reverse(reversedArray);

            return reversedArray;
        }

    }
}
