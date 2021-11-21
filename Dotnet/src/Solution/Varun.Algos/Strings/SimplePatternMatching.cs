using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.Strings
{
    public class SimplePatternMatching
    {
        private readonly string @string;
        public SimplePatternMatching(string @string)
        {
            this.@string = @string;
        }

        public int[] Match(string pattern)
        {
            List<int> matchIndexes = new List<int>();
            int stringLength = @string.Length;
            int patternLength = pattern.Length;
           
            for (int stringIndex = 0; stringIndex <= stringLength - patternLength; stringIndex++)
            {
                int patternIndex;
                for (patternIndex = 0; patternIndex < patternLength; patternIndex++)
                {
                    if (@string[stringIndex + patternIndex] != pattern[patternIndex])
                    {
                        break;
                    }
                   
                }
                if (patternIndex == patternLength)
                {
                    matchIndexes.Add(stringIndex);
                }
            }


            return matchIndexes.ToArray();
        }
    }
}
