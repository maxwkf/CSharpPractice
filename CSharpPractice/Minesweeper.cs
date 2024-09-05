using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class Minesweeper
    {
        public string Minemap { get; set; }
        public Minesweeper(string minemap = "*.*. ...* .*..") // 3x3 grid
        {
            this.Minemap = minemap;
        }

        public List<string[]> ResolveMap()
        {


            List<char[]> minemapArray = BreakToArray();
            List<string[]> resultArray = new List<string[]>();


            // initialize result array
            for (int i = 0; i < minemapArray.Count; i++) {
                resultArray.Add(new string[minemapArray[i].Length]);
            }

            for (int i = 0; i < minemapArray.Count; i++)
            {
                char[] currentRow = minemapArray[i];
                string[] rowResult = new string[currentRow.Length];
                
                
                for (int j = 0; j < currentRow.Length; j++)
                {
                    char lookingAtElement = currentRow[j];

                    // the lookingAtElement is a `.` in which I am not going to add numbers to surrounding result
                    // and I am going to retain the result as `*`
                    if (lookingAtElement.Equals('*'))
                    {
                        resultArray[i][j] = "*";
                    } else
                    {
                        continue;
                    }

                    for(int checkingRow = -1; checkingRow <= 1; checkingRow++)
                    {

                        for ( int checkingCol = -1; checkingCol <= 1; checkingCol++)
                        {

                            // if the element position does not exist, do nothing
                            if (
                                (i + checkingRow) < 0
                                || (j + checkingCol) < 0
                                || (i + checkingRow) >= minemapArray.Count
                                || (j + checkingCol) >= currentRow.Length
                            ) {
                                continue;
                            }




                            string targetResultContent = resultArray[i + checkingRow][j + checkingCol];

                            // if the result position is occupied with *, dont update it
                            if (targetResultContent != null && targetResultContent.Equals("*")) continue;

                            int currentCount = String.IsNullOrWhiteSpace(targetResultContent) ? 0 : Convert.ToInt32(targetResultContent);

                            resultArray[i + checkingRow][j + checkingCol] = (currentCount + 1).ToString();


                        }


                    }
                }


            }


            return resultArray;

        }

        private List<char[]> BreakToArray()
        {
            
            // split the string by " "
            List<string> splitedStringByEmpty = this.Minemap.Split(" ").ToList<string>();

            List<char[]> finalList = new List<char[]>();
            // for each of them put them to char[]
            splitedStringByEmpty.ForEach(row =>
            {
                finalList.Add(row.ToCharArray());
            });

            return finalList;
        }

        public override string ToString()
        {
            List<string[]> resolvedMap = ResolveMap();

            List<string> result = new List<string>();

            resolvedMap.ForEach(row =>
            {
                result.Add(String.Join("", row));
            });

            return String.Join(Environment.NewLine, this.Minemap.Split(" ").ToList<string>()) + Environment.NewLine + String.Join(Environment.NewLine, result);

        }
    }
}
