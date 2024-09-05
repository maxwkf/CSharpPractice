using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace CSharpPractice
{
    internal class Rectangle : IShape
    {
        private int width;
        private int height;

        public int Width { get { return width;  } set
            {
                width = value;
            }
        }

        public int Height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int GetArea()
        {
            return this.Width * this.Height;
        }

        public int GetPerimeter()
        {
            return (this.Width + this.Height ) *2;
        }
    }
}
