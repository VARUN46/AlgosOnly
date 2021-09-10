using NUnit.Framework;
using System;
using Varun.Algos.Linear.List;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Tests.List
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void TestListInt()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                var nodeItem1 = new Node<int>
                {
                    Value = i
                };
                linkedList.AddNode(nodeItem1);
            }
            Assert.AreEqual(linkedList.ToString(), "1 -> 2 -> 3 -> 4 -> 5 -> ");
        }

        [Test]
        public void TestListGitCommitLike()
        {
            LinkedList<string> linkedList = new();
            linkedList.AddNode(new Node<string> { Value = "Initial Commit" });
            for (int i = 1; i <= 3; i++)
            {
                linkedList.AddNode(new Node<string> { Value = $"Refactor {i}" });
            }
            Assert.AreEqual(linkedList.ToString(), "Initial Commit -> Refactor 1 -> Refactor 2 -> Refactor 3 -> ");
        }
    }
}
