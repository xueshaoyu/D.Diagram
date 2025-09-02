

using System.Xml.Serialization;

namespace D.Diagram.DrawingBox
{
    public class Wire
    {
        [XmlAttribute("From")]
        public string From { get; set; }

        [XmlAttribute("To")]
        public string To { get; set; }

        [XmlAttribute("FromPort")]
        public string FromPort { get; set; }

        [XmlAttribute("ToPort")]
        public string ToPort { get; set; }
    }
}
