﻿using System;
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
            new int[] { 1, 3 },
            new int[] { 2, 7 },
            new int[] { 1, 3 },
            new int[] { 2, 4 },
            new int[] { 6 },
            new int[] {},
            new int[] { 7 },
            new int[] { 5 }
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
                    return colors;
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
                new Node(Color.PURPLE),
                new Node(Color.YELLOW),
                new Node(Color.GREEN),
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

        static private void Dijkstra()
        {
            Node start = nodes[(int)Color.RED];

            start.minCost = 0;
            List<Node> queue = ;
        }
    }
}
