﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varun.Algos.Linear.List;

namespace Varun.Algos.NonLinear.Graphs.Undirected
{
    public class AdjacencyList : AdjacencyListGraphsBase
    {
        public AdjacencyList(int maxPosition)
        {
            linkedLists = new LinkedList<int>[maxPosition];
            for (int i = 0; i < maxPosition; i++)
            {
                linkedLists[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int x,int y)
        {
            linkedLists[MemoryMapIndex(x)].AddNode(new Node<int> { Value = MemoryMapIndex(y) });
            linkedLists[MemoryMapIndex(y)].AddNode(new Node<int> { Value = MemoryMapIndex(x) });
        }
    }
}