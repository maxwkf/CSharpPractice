using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class MyString
    {

        private string inputString;

        public string InputString {
            get
            {
                return inputString;
            }
            set
            {
                inputString = value;
            }
        }
        // shorter way
        //public string InputString { get => inputString; set => inputString = value; }

        private char[] inputStringInCharArray { get; set; }
        public MyString(string inputString)
        {
            this.setInputString(inputString);
        }

        public void setInputString(string inputString)
        {
            this.inputString = inputString;
            this.inputStringInCharArray = this.inputString.ToCharArray();
        }

        public string getReversedString()
        {
            string result = "";

            char[] reversedCharArray = this.inputString.Reverse().ToArray();

            result = new string(reversedCharArray);

            return result;
        }

        public Boolean IsPalindrome()
        {
            Boolean result = true;


            for (int i = 0, j = this.inputStringInCharArray.Length - 1; i < this.inputStringInCharArray.Length / 2; i++, j--) {
                if (this.inputStringInCharArray[i] != this.inputStringInCharArray[j])
                {
                    result = false;
                    break;
                }
            }


            return result;
        }
    }
}
