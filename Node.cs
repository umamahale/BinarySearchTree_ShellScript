﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BTree
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int data)
        {
            this.Data = data;

        }
    }
}
