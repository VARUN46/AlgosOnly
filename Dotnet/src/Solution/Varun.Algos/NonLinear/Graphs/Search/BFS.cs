using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs.Search
{
    public class BFS
    {
        private readonly DirectedGraphAL graph;
        public class DirectedGraphAL
        {
            private readonly List<LinkedList<int>> adjacencyList;
            public DirectedGraphAL(int vertices)
            {
                adjacencyList = new List<LinkedList<int>>(vertices);
                for (int i = 0; i < vertices; i++)
                {
                    adjacencyList.Add(new LinkedList<int>());
                }
            }

            public void AddEdge(int source,int destination)
            {
                adjacencyList[source].AddLast(destination);
            }

            public List<LinkedList<int>> GetAL()
            {
                return adjacencyList;
            }
        }

        private readonly bool[] isVisited;
        private readonly Queue<int> queue = new Queue<int>();
        private readonly StringBuilder stringBuilder = new StringBuilder();
        public BFS(DirectedGraphAL graph,int vertices)
        {
            this.graph = graph;
            this.isVisited = new bool[vertices + 1];
        }

        public void Traverse(int startVertex)
        {
            queue.Enqueue(startVertex);
            isVisited[startVertex] = true;
            ContextVertexLogic(startVertex);
            while (queue.Any())
            {
                var contextVertex = queue.Dequeue();
                foreach (var vertex in graph.GetAL()[contextVertex])
                {
                    if (!isVisited[vertex])
                    {
                        isVisited[vertex] = true;
                        ContextVertexLogic(vertex);
                        queue.Enqueue(vertex);
                    }
                }
            }
        }

        public void ContextVertexLogic(int vertex)
        {
            stringBuilder.Append($" {vertex} -> ");
        }

        public string GetResult()
        {
            return stringBuilder.ToString();
        }


    }
}
