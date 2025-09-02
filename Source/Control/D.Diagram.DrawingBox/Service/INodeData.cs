

using System.Windows;

namespace D.Diagram.DrawingBox
{
    public interface INodeData : IData
    {
        string ID { get; set; }

        Point Location { get; set; }

        void ApplayStyleTo(INodeData node);
    }
}
