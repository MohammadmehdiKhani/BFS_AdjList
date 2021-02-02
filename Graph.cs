using System;
using System.Collections.Generic;

namespace BFS
{
    public class Graph
    {
        Dictionary<int, List<int>> adjList;
        int vertexCount;
        Vertex[] vertexes;

        public Graph(Dictionary<int, List<int>> input)
        {
            adjList = input;
            vertexCount = adjList.Count;
            vertexes = new Vertex[vertexCount];

            for (int i = 0; i < vertexCount; i++)
            {
                vertexes[i] = new Vertex(Color.WHITE, null, i, int.MaxValue);
            }
        }

        public void BFS()
        {
            Queue<Vertex> queue = new Queue<Vertex>();

            Vertex source = vertexes[1];
            source.Color = Color.GRAY;
            source.Distance = 0;
            source.Parent = null;

            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                Vertex current = queue.Dequeue();

                for (int i = 0; i < vertexCount; i++)
                {
                    if (adjList[current.Number].Contains(i) && vertexes[i].Color == Color.WHITE)
                    {
                        Vertex destination = vertexes[i];
                        destination.Color = Color.GRAY;
                        destination.Distance = current.Distance + 1;
                        destination.Parent = current;

                        queue.Enqueue(destination);
                    }
                    current.Color = Color.BLACK;
                }
            }
        }

        public void PrintTree()
        {
            Array.Sort<Vertex>(vertexes);

            for (int i = 0; i < vertexes.Length; i++)
            {
                Vertex[] selected = Array.FindAll<Vertex>(vertexes, v => v.Distance == i);

                Console.WriteLine($"Level: {i}");

                foreach (var v in selected)
                {
                    Console.WriteLine($"{v.Label}-->{v.Parent?.Label ?? '0'}");
                }

                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
