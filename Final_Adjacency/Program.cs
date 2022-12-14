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
            Console.WriteLine();
            List<Node> path = Dijkstra(nodes[(int)Color.RED], nodes[(int)Color.GREEN]);
            foreach (Node node in path)
            {
                Console.WriteLine((Color)node.color);
            }
        }

        static int[,] adjacencyMatrix = new int[,]
        {
            //  Red     Blue    Teal    Grey    Orange  Green   Purple  Yellow
            {   -1,     1,      -1,     5,      -1,     -1,     -1,     -1   },  // red
            {   -1,     -1,     1,      -1,     -1,     -1,     -1,     8    },  // blue
            {   -1,     1,      -1,     0,      -1,     -1,     -1,     -1   },  // teal
            {   -1,     -1,     0,      -1,     1,      -1,     -1,     -1   },  // grey
            {   -1,     -1,     -1,     -1,     -1,     -1,     1,      -1   },  // orange
            {   -1,     -1,     -1,     -1,     -1,     -1,     -1,     -1   },  // green
            {   -1,     -1,     -1,     -1,     -1,     -1,     -1,     1    },  // purple
            {   -1,     -1,     -1,     -1,     -1,     6,      -1,     -1   }   // yellow
        };

        static int[][] adjacencyList = new int[][]
        {
            new int[] { (int)Color.BLUE, (int)Color.GREY    },  // red
            new int[] { (int)Color.YELLOW, (int)Color.TEAL  },  // blue
            new int[] { (int)Color.BLUE, (int)Color.GREY    },  // teal
            new int[] { (int)Color.TEAL, (int)Color.ORANGE  },  // grey
            new int[] { (int)Color.PURPLE                   },  // orange
            new int[] {                                     },  // green
            new int[] { (int)Color.YELLOW                   },  // purple
            new int[] { (int)Color.GREEN                    }   // yellow
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
