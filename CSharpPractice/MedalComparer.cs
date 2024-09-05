using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MedalComparer : IComparer
    {
        public int Compare(Object? x, Object? y)
        {
            const string GOLD = "Gold - ";
            const string SILVER = "Silver - ";
            const string BRONZE = "Bronze - ";

            string xString = Convert.ToString(x) ?? String.Empty;
            string yString = Convert.ToString(y) ?? String.Empty;

            if (String.IsNullOrWhiteSpace(xString) || String.IsNullOrWhiteSpace(yString)) return 1;




            Dictionary<string, int> rank = new Dictionary<string, int>{
                { GOLD, 1 },
                { SILVER, 2 },
                { BRONZE, 3 }
            };

            int xRank = rank[
                xString.Contains(GOLD) ? GOLD : (
                    xString.Contains(SILVER) ? SILVER : BRONZE
                )
            ];

            int yRank = rank[
                yString.Contains(GOLD) ? GOLD : (
                    yString.Contains(SILVER) ? SILVER : BRONZE
                )
            ];

            if (xRank.Equals(yRank)) return 0;
            if (xRank < yRank) return -1;

            return 1;
        }
    }
}
