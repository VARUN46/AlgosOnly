using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs.Search
{
    public class DFS
    {
        private readonly bool[] isVisited;
        private readonly DirectedGraphAL graph;
        private readonly Stack<int> currentStack = new Stack<int>();
        private StringBuilder stringBuilder = new StringBuilder();


        public DFS(DirectedGraphAL directedGraph, int vertices)
        {
            isVisited = new bool[vertices + 1];
            this.graph = directedGraph;

        }

        public void Traverse(int currentVertex)
        {
            CurrentContextLogic(currentVertex);
            isVisited[currentVertex] = true;
            var vertexNode = graph.GetAL()[currentVertex];
            foreach (var vertexSelected in vertexNode)
            {
                if (!isVisited[vertexSelected])
                {
                    Traverse(vertexSelected);
                }
            }
        }

        private void CurrentContextLogic(int vertex)
        {
            stringBuilder.Append(" " + vertex + " -> ");
        }

        public string GetResult()
        {
            return stringBuilder.ToString();
        }

        public class DirectedGraphAL
        {
            private readonly List<LinkedList<int>> adjacencyList = new List<LinkedList<int>>();

            public DirectedGraphAL(int vertices)
            {
                for (int i = 0; i < vertices; i++)
                {
                    adjacencyList.Add(new LinkedList<int>());
                }
            }

            public void AddEdge(int source, int destination)
            {
                adjacencyList[source].AddLast(destination);
            }

            public List<LinkedList<int>> GetAL()
            {
                return adjacencyList;
            }
        }



    }
}
