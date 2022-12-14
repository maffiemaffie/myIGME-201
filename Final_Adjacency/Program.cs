using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Adjacency
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Color> colors = DFS();
            foreach (Color color in colors)
            {
                Console.WriteLine(color.ToString());
            }

            Setup();
            List<Node> path = Dijkstra(nodes[(int)Color.BLUE], nodes[(int)Color.YELLOW]);
            foreach (Node node in path)
            {
                // Console.WriteLine((Color)node.color);
            }
        }

        static bool[,] adjacencyMatrix = new bool[,]
        {
            //  Red     Blue    Teal    Grey    Orange  Green   Purple  Yellow
            {   false,  true,   false,  true,   false,  false,  false,  false   },  // red
            {   false,  false,  true,   false,  false,  false,  false,  true    },  // blue
            {   false,  true,   true,   false,  false,  false,  false,  false   },  // teal
            {   false,  false,  false,  false,  true,   false,  false,  false   },  // grey
            {   false,  false,  false,  false,  false,  false,  true,   false   },  // orange
            {   false,  false,  false,  false,  false,  false,  false,  false   },  // green
            {   false,  false,  false,  false,  false,  false,  false,  true    },  // purple
            {   false,  false,  false,  false,  false,  true,   false,  false   }   // yellow
        };

        static int[][] adjacencyList = new int[][]
        {
            new int[] { 1, 3 }, // red
            new int[] { 7, 2 }, // blue
            new int[] { 1, 3 }, // teal
            new int[] { 2, 4 }, // grey
            new int[] { 6 },    // orange
            new int[] {},       // green
            new int[] { 7 },    // purple
            new int[] { 5 }     // yellow
        };

        public enum Color
        {
            RED,
            BLUE,
            TEAL,
            GREY,
            ORANGE,
            GREEN,
            PURPLE,
            YELLOW
        }

        static List<Color> DFS()
        {
            bool[] visited = new bool[adjacencyList.Length];

            return DFSUtil(0, visited);
        }

        static List<Color> DFSUtil(Color c, bool[] visited)
        {
            visited[(int)c] = true;
            List<Color> colors = new List<Color> { c };

            int[] thisStateList = adjacencyList[(int)c];
            foreach(Color thisC in thisStateList)
            {
                if (!visited[(int)thisC])
                {
                    colors.AddRange(DFSUtil(thisC, visited));
                }
            }
            return colors;
        }

        public class Node : IComparable<Node>
        {
            public Color color;
            public List<Edge> edges = new List<Edge>();

            public int minCost;
            public Node nearest;
            public bool visited;

            public Node(Color color)
            {
                this.color = color;
                this.minCost = int.MaxValue;
            }

            public void AddEdge(int cost, Node connection)
            {
                edges.Add(new Edge(cost, connection));
            }

            public int CompareTo(Node n)
            {
                return this.minCost.CompareTo(n.minCost);
            }

        }

        public class Edge : IComparable<Edge>
        {
            public int cost;
            public Node connection;

            public Edge(int cost, Node connection)
            {
                this.cost = cost;
                this.connection = connection;
            }

            public int CompareTo(Edge e)
            {
                return this.cost.CompareTo(e.cost);
            }
        }

        static List<Node> nodes = new List<Node>();

        static private void Setup()
        {
            nodes.AddRange(new List<Node>{
                new Node(Color.RED),
                new Node(Color.BLUE),
                new Node(Color.TEAL),
                new Node(Color.GREY),
                new Node(Color.ORANGE),
                new Node(Color.GREEN),
                new Node(Color.PURPLE),
                new Node(Color.YELLOW)
            });

            nodes[(int)Color.RED].edges.AddRange(new List<Edge> {
                new Edge(1, nodes[(int)Color.BLUE]),
                new Edge(5, nodes[(int)Color.GREY])
            });
            nodes[(int)Color.RED].edges.Sort();

            nodes[(int)Color.BLUE].edges.AddRange(new List<Edge> {
                new Edge(1, nodes[(int)Color.TEAL]),
                new Edge(8, nodes[(int)Color.YELLOW])
            });
            nodes[(int)Color.BLUE].edges.Sort();

            nodes[(int)Color.TEAL].edges.AddRange(new List<Edge> {
                new Edge(1, nodes[(int)Color.BLUE]),
                new Edge(0, nodes[(int)Color.GREY])
            });
            nodes[(int)Color.TEAL].edges.Sort();

            nodes[(int)Color.GREY].edges.AddRange(new List<Edge> {
                new Edge(0, nodes[(int)Color.TEAL]),
                new Edge(1, nodes[(int)Color.ORANGE])
            });
            nodes[(int)Color.GREY].edges.Sort();

            nodes[(int)Color.ORANGE].edges.AddRange(new List<Edge> {
                new Edge(1, nodes[(int)Color.PURPLE])
            });
            nodes[(int)Color.ORANGE].edges.Sort();

            nodes[(int)Color.PURPLE].edges.AddRange(new List<Edge> {
                new Edge(1, nodes[(int)Color.YELLOW])
            });
            nodes[(int)Color.PURPLE].edges.Sort();

            nodes[(int)Color.YELLOW].edges.AddRange(new List<Edge> {
                new Edge(6, nodes[(int)Color.GREEN])
            });
            nodes[(int)Color.YELLOW].edges.Sort();

            nodes[(int)Color.GREEN].edges.AddRange(new List<Edge> {});
            nodes[(int)Color.GREEN].edges.Sort();
        }

        static private List<Node> Dijkstra(Node start, Node end)
        {
            start.minCost = 0;
            
            List<Node> queue = new List<Node>(nodes);

            Node current = start;

            do
            {
                foreach (Edge edge in current.edges)
                {
                    Node connection = edge.connection;

                    if (!connection.visited && (current.minCost + edge.cost < connection.minCost))
                    {
                        connection.minCost = current.minCost + edge.cost;
                        connection.nearest = current;
                    }
                }
                current.visited = true;
                queue.Remove(current);
                queue.Sort();
                current = queue[0];

            } while (queue.Count > 0 && current != end);

            return TraceBack(end);
        }

        static private List<Node> TraceBack(Node node)
        {
            List<Node> path = new List<Node>() { node };
            if (node.nearest != null) path.InsertRange(0, TraceBack(node.nearest));
            return path;
        }
    }
}
