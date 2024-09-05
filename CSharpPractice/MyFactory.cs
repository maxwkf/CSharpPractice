using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class MyFactory
    {
        public IShape? Shape { get; set; }

        public MyFactory() { }

        
        public MyFactory(IShape shape)
        {
            this.Shape = shape;
        }

        public void GenerateDetail()
        {
            if (this.Shape == null)
            {
                throw new InvalidOperationException("Shape is not initialized.");
            }

            Console.WriteLine($"The area of the shape is {this.Shape.GetArea()}");
            Console.WriteLine($"The perimeter of the shape is {this.Shape.GetPerimeter()}");
        }
    }
}
