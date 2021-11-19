using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.NonLinear.Graphs.Search;

namespace Algos.Tests.Graphs
{
    [TestFixture]
    public class TraversalTests
    {
        [Test]
        public void DfsTest()
        {
            DFS.DirectedGraphAL graph = new DFS.DirectedGraphAL(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            DFS dFS = new DFS(graph, 4);
            dFS.Traverse(2);
            var result = dFS.GetResult();
            Assert.AreEqual(" 2 ->  0 ->  1 ->  3 -> ", result);
        }

        [Test]
        public void BfsTest()
        {
            BFS.DirectedGraphAL graph = new BFS.DirectedGraphAL(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            BFS dFS = new BFS(graph, 4);
            dFS.Traverse(2);
            var result = dFS.GetResult();
            Assert.AreEqual(" 2 ->  0 ->  3 ->  1 -> ", result);
        }



    }
}
