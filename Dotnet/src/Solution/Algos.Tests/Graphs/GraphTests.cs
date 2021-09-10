using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.NonLinear.Graphs;

namespace Algos.Tests.Graphs
{
   [TestFixture]
    public class GraphTests
    {
        [Test]
        public void TestBasic()
        {
            AdjacencyList.Pair root = new()
            {
                Position = 1
            };
            AdjacencyList.Pair pair13 = new()
            {
                Position = 3
            };
            root.Next = pair13;
            AdjacencyList.Pair pair35 = new()
            {
                Position = 5
            };
            pair13.Next = pair35;
            AdjacencyList adjacencyList = new(1);
            adjacencyList.AddPairs(root);
            Assert.AreEqual(adjacencyList.DebugPrintFull(), "-->1-->3-->5|");
        }
    }
}
