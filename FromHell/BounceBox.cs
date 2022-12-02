using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHell
{
    public class BounceBox
    {
        static int Count = 0;

        private int left;
        private int right;
        private int top;
        private int bottom;

        private int x;
        private int y;

        private int width;
        private int height;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        private int dx;
        private int dy;

        private String name;
        public String Name { get { return name; } }

        public BounceBox(String name, int left, int right, int top, int bottom, int x, int y, int width, int height)
        {
            Count++;

            this.name = name;
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            dx = 10;
            dy = 10;

            if (Count % 2 == 0 ) dx *= -1;
            if (Count % 4 < 2) dy *= -1;
        }

        public void Update()
        {
            if (x + dx + width > right || x + dx < left) dx = -dx;
            if (y + dy + height > top || y + dy < bottom) dy = -dy;

            x += dx;
            y += dy;
        }
    }
}
