using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class OutputGenerator
    {
        public static string Generate(params int[] heights)
        {
            int index = -1, max = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                    index = i;

                }
            }
            return "" + index;
        }
    }
}
