using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root;
        public BinarySearchTree()
        {
            this.root = null;
        }
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
        public int Size(Node<T> node)
        {
            if (node == null) 
                return (0);
            else
            {
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
        public int SizeOfTree()
        {
            return (Size(root));
        }
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
