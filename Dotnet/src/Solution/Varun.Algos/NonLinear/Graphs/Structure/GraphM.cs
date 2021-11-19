using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs.Structure
{
    public class GraphM
    {
        private readonly List<List<int>> matrix = new List<List<int>>();
        public GraphM(int vertices)
        {
            for (int i = 0; i < vertices; i++)
            {
                matrix.Add(Enumerable.Repeat(0, vertices).ToList());
                
            }
        }

        public void AddEdgeUndirected(int source,int destination)
        {
            matrix[source][destination] = 1;
            matrix[destination][source] = 1;
        }

        public List<List<int>> GetMatrix()
        {
            return matrix;
        }

    }
}
