using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterview.Tests.DataStructures.TreesAndGraphs
{
    [TestClass]
    public class GraphTest
    {
        [TestMethod]
        public void UnidirecionalTests()
        {
            var solution = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.Graph();
            solution.AddEdge(6, 5, false);
            solution.AddEdge(6, 3, false);
            solution.AddEdge(5, 4, false);
            solution.AddEdge(4, 6, false);
        }

        [TestMethod]
        public void BidiretionalTests()
        {
            var solution = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.Graph();
            solution.AddEdge(6, 5, true);
            solution.AddEdge(6, 3, true);
            solution.AddEdge(5, 4, true);
            solution.AddEdge(4, 6, true);
        }

        [TestMethod]
        public void MixedTests()
        {
            var solution = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.Graph();
            solution.AddEdge(0, 1, false);
            solution.AddEdge(1, 2, false);
            solution.AddEdge(2, 0, false);
            solution.AddEdge(2, 3, false);
        }

        [TestMethod]
        public void DFS_Unidirecional()
        {
            var solution = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.Graph();
            solution.AddEdge(0, 1, false);
            solution.AddEdge(0, 4, false);
            solution.AddEdge(0, 5, false);
            solution.AddEdge(1, 3, false);
            solution.AddEdge(1, 4, false);
            solution.AddEdge(3, 4, false);
            solution.AddEdge(3, 2, false);

            var expected = new[] { 0, 1, 3, 4, 2, 5 };

            var actual = solution.DepthFirstSearch(0);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DFSBidirecional()
        {
            var solution = new CrackingTheCodingInterview.DataStructures.TreesAndGraphs.Graph();
            solution.AddEdge(0, 1, false);
            solution.AddEdge(0, 4, false);
            solution.AddEdge(0, 5, false);
            solution.AddEdge(1, 3, true);
            solution.AddEdge(1, 4, false);
            solution.AddEdge(3, 4, true);
            solution.AddEdge(3, 2, false);

            var expected = new[] { 0, 1, 3, 4, 2, 5 };

            var actual = solution.DepthFirstSearch(0);

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
