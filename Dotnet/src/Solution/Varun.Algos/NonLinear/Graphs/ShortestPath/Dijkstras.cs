using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Graphs.ShortestPath
{
    public class Dijkstras
    {
        private readonly int[,] graph;
        private readonly int vertices;
        public Dijkstras(int[,] graph,int vertices)
        {
            this.graph = graph;
            this.vertices = vertices;
        }

        public (int[],bool[]) InitializeValues()
        {
            var dist = new int[vertices];
            var sptSet = new bool[vertices];
            for (int v = 0; v < vertices; v++)
            {
                //Initialize Distance as Infinity/MaxValue
                dist[v] = int.MaxValue;
            }

            return (dist, sptSet);
        }

        public void FindMinDistance(int startVertex)
        {
            var (dist, sptSet) = InitializeValues();
            //Distance from Itself will be zero
            dist[startVertex] = 0;
            int minDistance = int.MaxValue;
            int minIndex = -1;
            for(int iv = 0; iv < vertices; iv++)
            {
                if(!sptSet[iv] && dist[iv] <= minDistance)
                {
                    minDistance = dist[iv];
                    minIndex = iv;

                }
            }

        }


    }
}
