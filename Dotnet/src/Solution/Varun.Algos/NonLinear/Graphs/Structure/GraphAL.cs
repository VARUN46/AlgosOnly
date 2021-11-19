using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs.Structure
{
    public class GraphAL
    {
        private List<LinkedList<int>> adjacencyListData;

        /// <summary>
        /// //Empty Structure Is Initialized
        /// </summary>
        /// <param name="vertices">Number of Vertex</param>
        public GraphAL(int vertices)
        {  
            adjacencyListData = new List<LinkedList<int>>();
            for (int i = 0; i < vertices; i++)
            {
                adjacencyListData.Add(new LinkedList<int>());
            }
        }

        public void AddEdgeUndirected(int source,int destination)
        {
            adjacencyListData[source].AddLast(destination);
            adjacencyListData[destination].AddLast(source);
        }

        public List<LinkedList<int>> GetLinkedList()
        {
            return adjacencyListData;
        }
    }
}
