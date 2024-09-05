using System;
using System.Runtime.CompilerServices;

namespace MyLibrary
{
    class MyList
    {
        public List<string> inputList;

        public MyList(List<string> inputList)
        {
            this.inputList = inputList;
        }


        /// <summary>
        /// Check if the string <paramref name="needle"/> exists in the inputList that
        /// had been initialized in constructor.
        /// 
        /// If exists, return true and false vice versa.
        /// The corresponding index will be returned in the out int index
        /// </summary>
        /// <param name="needle">The string to search</param>
        /// <param name="index">The corresponding index to be returned</param>
        /// <returns>bool</returns>
        public bool IsStringExists(string needle, out int index)
        {
            index = -1;
            bool result = false;

            for(int i = 0; i < this.inputList.Count; i++)
            {
                string item = this.inputList[i];
                if (item.ToLower().Equals(needle))
                {
                    index = i;
                    result = true;
                }
            }

            return result;
        }
    }
}