using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.NonLinear.Graphs.Undirected;

namespace Algos.Tests.Graphs
{
    [TestFixture]
    public class UndirectedAdjacencyListTests
    {
        [Test]
        public void CreateGraphTest()
        {
            AdjacencyList graph = new AdjacencyList(3);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(1, 3);
            Assert.AreEqual(graph.ToString(), "1 -> 2 -> 3 -> |2 -> 1 -> 3 -> |3 -> 2 -> 1 -> |");
        }
    }
}
