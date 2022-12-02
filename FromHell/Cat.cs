using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHell
{
    [Flags]
    public enum Color
    {
        ORANGE  = 0b_0000_0001,
        BLACK   = 0b_0000_0010,
        GREY    = 0b_0000_0100,
        WHITE   = 0b_0000_1000,
        BROWN   = 0b_0001_0000
    }

    public enum Sillyness
    {
        NORMAL  = 0b_0001,
        QUIRKY  = 0b_0010,
        SILLY   = 0b_0100
    }
    public class Cat
    {
        private String name;
        private Color color;
        private Sillyness sillyness;
        
        public String Name { get { return name; } }
        public Color Color { get { return color; } }
        public Sillyness Sillyness { get { return sillyness; } }

        public Cat(string name, Color color, Sillyness sillyness)
        {
            this.name = name;
            this.color = color;
            this.sillyness = sillyness;
        }
    }
}
