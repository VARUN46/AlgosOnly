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
        [TestCase(12, 11, 13, 5, 6, 7)]
        public void DoHeapSort(params int[] arr)
        {
            HeapSort sorter = new HeapSort();
            sorter.Sort(arr);
        }
    }
}
