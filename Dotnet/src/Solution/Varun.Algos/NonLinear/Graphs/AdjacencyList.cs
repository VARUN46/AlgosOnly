using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs
{
    public class AdjacencyList
    {
        private Pair[] pairs;
        private int index = -2;
        public AdjacencyList(int length)
        {
            pairs = new Pair[length];
            index = -1;
        }

        public void AddPairs(Pair pair)
        {
            pairs[++index] = pair;
            Console.WriteLine(DebugPrintFull());
        }

        public string DebugPrintFull()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in pairs)
            {
                var currIndex = item;
                while (currIndex != null)
                {
                    stringBuilder.Append("-->"+currIndex);
                    currIndex = currIndex.Next;
                }
                stringBuilder.Append("|");
                
            }
            return stringBuilder.ToString();
        }

        public class Pair
        {
            public int Position { get; set; }

            public Pair Next { get; set; }

            public override string ToString()
            {
                return Convert.ToString(Position);
            }
        }
    }
}
