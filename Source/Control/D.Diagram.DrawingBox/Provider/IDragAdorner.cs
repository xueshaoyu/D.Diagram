


using System.Windows;

namespace D.Diagram.DrawingBox
{
    public interface IDragAdorner
    {
        Point Offset { get; set; }
        void UpdatePosition(Point location);
        object GetData();
    }
}



