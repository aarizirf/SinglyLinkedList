using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlyLinkedList
{
    class SinglyLinkedList<T>
    {
        SinglyLinkedNode<T> head;
        int count;

        public SinglyLinkedList()
        {
            count = 0;
            head = null;
        }

        /// <summary>
        /// Adds a value to the end
        /// </summary>
        /// <param name="value">What is being added</param>
        public void AddLast(T value)
        {
            if(head == null)
            {
                head = value;
            }
        }

    }
}