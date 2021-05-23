using System;
using System.Collections;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.DataStructures.TreesAndGraphs
{
    

    public class Graph
    {
        private Dictionary<int, int[]> _adjacentList = new Dictionary<int, int[]>();
        private List<int> _dfsResult = new List<int>();

        public void AddVertex(int value)
        {
            _adjacentList.Add(value, null);
        }
        public void AddEdge(int left, int right, bool bidirectional)
        {
            AddItem(left, right);

            if (bidirectional)
            {
                AddItem(right, left);
            }
        }
        public int[] GetVertexes(int node)
        {
            return _adjacentList[node];
        }

        private void AddItem(int node1, int node2)
        {
            if (!_adjacentList.ContainsKey(node1))
            {
                AddVertex(node1);
            }

            var value = _adjacentList[node1] as int[];
            if (value == null)
            {
                _adjacentList[node1] = new int[1] { node2 };
                return;
            }

            var newValue = new int[value.Length + 1];
            value.CopyTo(newValue, 0);
            newValue[value.Length] = node2;

            _adjacentList[node1] = newValue;
        }


        public int[] DepthFirstSearch(int root)
        {
            _dfsResult.Clear();

            if (!_adjacentList.ContainsKey(root))
            {
                return _dfsResult.ToArray();
            }

            HashSet<int> visited = new HashSet<int>();
            visited.Add(root);

            _dfsResult.Add(root);
            Visit(root, visited);

            return _dfsResult.ToArray();
        }
        private void Visit(int node, HashSet<int> visited)
        {
            if (!_adjacentList.ContainsKey(node))
            {
                return;
            }


            var children = _adjacentList[node];
            foreach (var child in children)
            {
                if (!visited.Contains(child))
                {
                    _dfsResult.Add(child);
                    visited.Add(child);
                    Visit(child, visited);
                }
            }

        }
    }
}
