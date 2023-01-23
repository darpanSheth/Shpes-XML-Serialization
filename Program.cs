using static System.Console;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Module2AssignmentQuestion1;
using System.IO;
using static System.IO.Path;
using static System.IO.Directory;
using static System.Environment;




var listOfShapes = new List<Shape>
{
new Circle { Colour = "Red", Radius = 2.5 },
new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
new Circle { Colour = "Green", Radius = 8 },
new Circle { Colour = "Purple", Radius = 12.3 },
new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
};


var xs = new XmlSerializer(typeof(List<Shape>)) ;

string fileXml = Combine(CurrentDirectory, "shapes.xml");

using (FileStream file = File.Create(fileXml))
{
    xs.Serialize(file, listOfShapes);
}


using (FileStream xmlLoad = File.Open(fileXml, FileMode.Open))
{ List<Shape> loadedShapesXml = xs.Deserialize(xmlLoad) as List<Shape>;
    foreach (Shape item in loadedShapesXml)
    {
        WriteLine($"{item.GetType().Name} is {item.Colour} and has an " +
    
        $"area of {item.Area}");
    }
}

