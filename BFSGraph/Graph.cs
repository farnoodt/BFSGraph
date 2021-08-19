using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSGraph
{
    class Graph
    {
        List<List<int>> adj = new List<List<int>>();
        int Nodes;

        public Graph(int N)
        {
            this.Nodes = N;
            for (int i = 0; i < N; i++)
            {
                adj.Add(new List<int>());
            }
        }

        public void AddEdge(int Source, int Destination)
        {
            adj[Source].Add(Destination);
        }

        public void BFS(int StartNode)
        {
            bool[] visited = new bool[Nodes];
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(StartNode);
            Console.Write(StartNode);

            while(Q.Count != 0)
            {
                Console.WriteLine();
                int Current = Q.Dequeue();

                foreach (var child in adj[Current])
                {
                    if(!visited[child])
                    {
                        Console.Write(child);
                        visited[child] = true;
                        Q.Enqueue(child);
                    }
                }

            }
        }
    }
}
