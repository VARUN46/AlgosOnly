using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.NonLinear.Graphs.Structure;

namespace Algos.Tests.Graphs
{
    [TestFixture]
    internal class RepresentationTests
    {
        [Test]
        public void CreateAdjacencyList()
        {
            GraphAL graph = new GraphAL(5);
            graph.AddEdgeUndirected(0, 1);
            graph.AddEdgeUndirected(0, 4);
            graph.AddEdgeUndirected(1, 2);
            graph.AddEdgeUndirected(1, 3);
            graph.AddEdgeUndirected(1, 4);
            graph.AddEdgeUndirected(2, 3);
            graph.AddEdgeUndirected(3, 4);
            var resultData = graph.GetLinkedList();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5, resultData.Count); //Has 0,1,2,3,4
                Assert.AreEqual(1, resultData[0].First.Value);
                Assert.AreEqual(4, resultData[0].Last.Value);
                Assert.AreEqual(4, resultData[0].Last.Value);    
            });

        }
    }
}
