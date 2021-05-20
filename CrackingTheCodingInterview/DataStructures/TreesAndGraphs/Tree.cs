using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.TreesAndGraphs
{
    class Tree
    {
        public class Node
        {
            public string name { get; set; }
            public Node[] children { get; set; }
        }

        public Node root { get; set; }
    }
}
