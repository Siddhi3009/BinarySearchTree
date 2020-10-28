using System;
using System.Collections.Generic;
using System.Text;
namespace BinarySearchTree
{
    /// <summary>
    /// Binary search tree operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;
        /// <summary>
        /// Root node initialisation of binary tree
        /// </summary>
        public BinarySearchTree()
        {
            this.root = null;
        }
        /// <summary>
        /// Inserts new element in binary tree
        /// </summary>
        /// <param name="element"></param>
        public void Insert(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (root == null)
                root = newNode;
            else
            {
                Node<T> current = root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    if (element.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Calculates size of tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns> returns size of tree</returns>
        public int Size(Node<T> node)
        {
            if (node == null) 
                return (0);
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
        /// <summary>
        /// Calculates size of tree using root node
        /// </summary>
        /// <returns>Size of tree is returned</returns>
        public int SizeOfTree()
        {
            return (Size(root));
        }
        /// <summary>
        /// Searches for an element in binary tree
        /// </summary>
        /// <param name="value"></param>
        public void BinarySearch(T value)
        {
            Node<T> current = root;
            bool elementFound = false;
            while (current!= null)
            {
                if (current.data.Equals(value))
                {
                    elementFound = true;
                    break;
                }
                else 
                {
                    if (value.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (elementFound)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element doesn't exist in the tree");
        }
    }
}
