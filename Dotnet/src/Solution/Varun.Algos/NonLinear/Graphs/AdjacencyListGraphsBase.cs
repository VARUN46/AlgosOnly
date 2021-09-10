using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.Linear.List;

namespace Varun.Algos.NonLinear.Graphs
{
    public abstract class AdjacencyListGraphsBase
    {
        protected LinkedList<int>[] linkedLists;
        protected int MemoryMapIndex(int index)
        {
            return index - 1;
        }

        protected int PresentationMapIndex(int index)
        {
            return index + 1;
        }

        public override string ToString()
        {
            StringBuilder result = new();
            for (int i = 0; i < linkedLists.Length; i++)
            {
                var currentNode = linkedLists[i].GetHead();
                result.Append($"{PresentationMapIndex(i)} -> ");
                while (currentNode != null)
                {
                    result.Append($"{PresentationMapIndex(currentNode.Value)} -> ");
                    currentNode = currentNode.Next;
                }
                result.Append("|");
            }

            return result.ToString();
        }
    }
}
