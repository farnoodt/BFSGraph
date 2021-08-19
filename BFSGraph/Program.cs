using System;

namespace BFSGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph G = new Graph(5);

            G.AddEdge(0, 1);
            G.AddEdge(0, 2);
            G.AddEdge(1, 3);
            G.AddEdge(2, 4);
            G.AddEdge(3, 4);

            G.BFS(0);
            Console.ReadLine();
        }
    }
}
