using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_UT2_09_10
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            Marker marker = new Marker("red");
            Paper paper = new Paper(8, 11);
            Whiteboard whiteboard = new Whiteboard(30, 20);

            DrawPicture(paper, marker);
            DrawPicture(whiteboard, marker);
        }

        static void DrawPicture(object canvas, object tool)
        {
            ((DrawingBoard)canvas).Clear();

            try
            {
                ((IDrawingMaterial)tool).Draw();
            } catch { }

            ((DrawingUtensil)tool).DrawOutline();

            try
            {
                ((IErasableBoard)canvas).Erase();
            }
            catch { }
            
            Console.WriteLine("You completed your masterpiece!");
        }

        public interface IDrawingMaterial
        {
            void Draw();
        }

        public abstract class DrawingUtensil
        {
            public string color;

            public abstract void DrawOutline();

            public DrawingUtensil(string color)
            {
                this.color = color;
            }
        }

        public interface IErasableBoard
        {
            void Erase();
        }

        public abstract class DrawingBoard
        {
            public int width;
            public int height;

            private string material;
            public string Material
            {
                get { return material; }
            }

            public virtual void Clear()
            {
                Console.WriteLine("You grabbed a new canvas");
            }

            public DrawingBoard(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        public class Marker : DrawingUtensil, IDrawingMaterial
        {
            public override void DrawOutline()
            {
                Console.WriteLine("You markered a {0} outline.", color);
            }

            public void Draw()
            {
                Console.WriteLine("You drew a {0} cat. It seems you only know how to draw a cat.", color);
            }

            public Marker(string color) : base(color)
            {
                Console.WriteLine("You grabbed a {0} marker", color);
            }
        }

        public class Whiteboard : DrawingBoard, IErasableBoard
        {
            public override void Clear()
            {
                Console.WriteLine("Getting a brand new whiteboard would be expensive. You just erased everything on it.");
            }

            public void Erase()
            {
                Console.WriteLine("You erased a few erroneous marks.");
            }

            public Whiteboard(int width, int height) : base(width, height)
            {
                if (width * height < 50)
                {
                    Console.WriteLine("You grabbed a small whiteboard.");
                }
                else if (width * height < 300)
                {
                    Console.WriteLine("You grabbed a normal whiteboard.");
                }
                else
                {
                    Console.WriteLine("You grabbed a large whiteboard.");
                }
            }
        }

        public class Paper : DrawingBoard
        {

            public override void Clear()
            {
                Console.WriteLine("You grabbd a new sheet of paper.");
            }
            public Paper(int width, int height) : base(width, height)
            {
                if (width * height < 20)
                {
                    Console.WriteLine("You grabbed a small piece of paper.");
                }
                else if (width * height < 100)
                {
                    Console.WriteLine("You grabbed a normal piece of paper.");
                }
                else
                {
                    Console.WriteLine("You grabbed a large piece of paper.");
                }
            }
        }
    }
}
