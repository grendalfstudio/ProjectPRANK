using System;

namespace GoodsTransportation
{
    internal class GFG
    {
        private static int V;
        private static int[] dist;


        private int minDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value 
            var min = int.MaxValue;
            var min_index = -1;

            for (var v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print 
        // the constructed distance array 
        public void printSolution(int[] dist)
        {
            Console.Write("Vertex	 Distance "
                          + "from Source\n");
            for (var i = 0; i < V; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }

        // Funtion that implements Dijkstra's 
        // single source shortest path algorithm
        private void dijkstra(int[,] graph, int src)
        {
            dist = new int[V];
            var sptSet = new bool[V];

            // Initialize all distances as 
            // INFINITE and stpSet[] as false 
            for (var i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            // Find shortest path for all vertices 
            for (var count = 0; count < V - 1; count++)
            {
                var u = minDistance(dist, sptSet);

                // Mark the picked vertex as processed 
                sptSet[u] = true;

                for (var v = 0; v < V; v++)

                    // Update dist[v] only if is not in sptSet
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            //print the constructed distance array 
            //printSolution(dist, V);
        }

        public int[] GetSolution(int[,] graph, int src)
        {
            V = (int) Math.Sqrt(graph.Length);
            dijkstra(graph, src);
            return dist;
        }
    }
}