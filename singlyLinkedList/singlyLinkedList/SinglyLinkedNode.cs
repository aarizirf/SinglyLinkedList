﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singlyLinkedList
{
    class SinglyLinkedNode<T>
    {
        public T Item { get; set; }
        public SinglyLinkedNode<T> Next { get; set; }

        public SinglyLinkedNode(T itemToStore, SinglyLinkedNode<T> next = null)
        {
            Item = itemToStore;
            Next = next;
        }
    }
}
