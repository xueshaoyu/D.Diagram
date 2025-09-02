

using System.Windows.Controls;
using System.Xml.Serialization;

namespace D.Diagram.DrawingBox
{
    public class Socket
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Dock")]
        public Dock Dock { get; set; }

        [XmlAttribute("Color")]
        public string Color { get; set; }

        [XmlAttribute("Index")]
        public int Index { get; set; }
    }
}
