using System;
using System.Xml.Serialization;

namespace Module2AssignmentQuestion1
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public class Shape
	{
		public string Colour { get; set; }

		public virtual double Area { get; set; }
	}
}

