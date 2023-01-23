using System;
namespace Module2AssignmentQuestion1
{
	public class Circle : Shape
	{
		public double Radius { get; set; }


        public override double Area { get => Math.PI * Radius * Radius;  }

    }
}

