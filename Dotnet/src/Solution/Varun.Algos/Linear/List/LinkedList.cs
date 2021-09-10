using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.Linear.List
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public void AddNode(Node<T> node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                var traversalNode = head;
                while (traversalNode.Next != null)
                {
                    traversalNode = traversalNode.Next;
                }
                traversalNode.Next = node;
            }
           
        }

        public override string ToString()
        {
            StringBuilder result = new ();

            var traversalNode = head;
            while (traversalNode != null)
            {
                result.Append($"{traversalNode.Value} -> ");
                traversalNode = traversalNode.Next;
            }
            return result.ToString();
        }


    }
}
