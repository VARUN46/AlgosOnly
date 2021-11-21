using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.NonLinear.Trees.Sorting;

namespace Algos.Tests.Trees
{
    [TestFixture]
    public class SortTests
    {
        [Test]
        [TestCase(12, 11, 6, 5, 13, 7)]
        [TestCase(12, 11, 6, 5, 13, 7, 12, 11, 6, 5, 13, 7, 12, 11, 6, 5, 13, 7)]
        public void DoHeapSort(params int[] arr)
        {
            var expected = (int[])arr.Clone();
            Array.Sort(expected);

            HeapSort sorter = new HeapSort();
            sorter.Sort(arr);

            Assert.AreEqual(expected, arr);
        }
    }
}
