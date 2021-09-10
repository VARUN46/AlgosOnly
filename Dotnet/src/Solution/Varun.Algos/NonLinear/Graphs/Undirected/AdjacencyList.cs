using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.Linear.List;

namespace Varun.Algos.NonLinear.Graphs.Undirected
{
    public class AdjacencyList
    {
        private readonly LinkedList<int>[] linkedLists;
        public AdjacencyList(int maxPosition)
        {
            linkedLists = new LinkedList<int>[maxPosition];
            for (int i = 0; i < maxPosition; i++)
            {
                linkedLists[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int x,int y)
        {
            linkedLists[MemoryMapIndex(x)].AddNode(new Node<int> { Value = MemoryMapIndex(y) });
            linkedLists[MemoryMapIndex(y)].AddNode(new Node<int> { Value = MemoryMapIndex(x) });
        }

        private int MemoryMapIndex(int index)
        {
            return index - 1;
        }

        private int PresentationMapIndex(int index)
        {
            return index + 1;
        }

        public override string ToString()
        {
            StringBuilder result = new ();
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
