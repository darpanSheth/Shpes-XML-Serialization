using System;
namespace Module2AssignmentQuestion1
{
	public class Rectangle : Shape
	{
		public double Height { get; set; }
		public double Width { get; set; }

        public override double Area { get => Height * Width;  }

    }
}

