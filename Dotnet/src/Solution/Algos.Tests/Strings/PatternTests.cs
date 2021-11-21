using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.Strings;

namespace Algos.Tests.Strings
{
    [TestFixture]
    public class PatternTests
    {
        [Test]
        [TestCase("AABA", new[] { 0,9,13 })]
        public void DoSimplePatternMatching(string pattern,int[] actual)
        {
            SimplePatternMatching matching = new SimplePatternMatching("AABAACAADAABAAABAA");
            var expected = matching.Match(pattern);
            Assert.AreEqual(actual, expected);
        }
    }
}
