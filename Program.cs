using System;
using System.Collections.Generic;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, List<int>> input = GraphHelper.Parse(@".\input.txt");
            Graph graph = new Graph(input);

            graph.BFS();
            graph.PrintTree();
        }
    }
}