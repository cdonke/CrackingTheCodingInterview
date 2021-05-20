using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodingInterview.DataStructures.TreesAndGraphs
{
    public class BinaryTree<T>
    {
        public class BinaryNode
        {
            public BinaryNode(T value)
            {
                this.value = value;
            }
            public T value { get; set; }
            public BinaryNode left { get; set; }
            public BinaryNode right { get; set; }
        }

        private BinaryNode root;

        public void Insert(T value)
        {
            var node = new BinaryNode(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var currentNode = root;

            if (root == null)
            {
                root = node;
                return;
            }

            while (currentNode != null)
            {
                var compare = Comparer<T>.Default.Compare(value, currentNode.value);

                switch (compare)
                {
                    case 0:
                        return;

                    case -1:
                        if (currentNode.left == null)
                        {
                            currentNode.left = node;
                            return;
                        }

                        currentNode = currentNode.left;
                        break;

                    case 1:
                        if (currentNode.right == null)
                        {
                            currentNode.right = node;
                            return;
                        }

                        currentNode = currentNode.right;
                        break;
                }
            }
        }

        public bool Find(T value)
        {
            var currentNode = root;
            while (currentNode != null)
            {
                var compare = Comparer<T>.Default.Compare(value, currentNode.value);
                if (compare == 0)
                {
                    return true;
                }
                else if (compare < 0)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }

            return false;
        }

        public void InOrderTraversal(Action<BinaryNode> visit) => InOrderTraversal(root, visit);
        public void InOrderTraversal(BinaryNode node, Action<BinaryNode> visit)
        {
            if (node != null)
            {
                InOrderTraversal(node.left, visit);
                visit(node);
                InOrderTraversal(node.left, visit);
            }
        }

        public void PreOrderTraversal(Action<BinaryNode> visit) => PreOrderTraversal(root, visit);
        public void PreOrderTraversal(BinaryNode node, Action<BinaryNode> visit)
        {
            if (node != null)
            {
                visit(node);
                InOrderTraversal(node.left, visit);
                InOrderTraversal(node.left, visit);
            }
        }

        public void PostOrderTraversal(Action<BinaryNode> visit) => PostOrderTraversal(root, visit);
        public void PostOrderTraversal(BinaryNode node, Action<BinaryNode> visit)
        {
            if (node != null)
            {
                InOrderTraversal(node.left, visit);
                InOrderTraversal(node.left, visit);
                visit(node);
            }
        }

    }
}
