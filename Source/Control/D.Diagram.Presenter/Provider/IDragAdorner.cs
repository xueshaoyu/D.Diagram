


using System.Windows;

namespace H.Controls.Adorner
{
    public interface IDragAdorner
    {
        Point Offset { get; set; }
        void UpdatePosition(Point location);
        object GetData();
    }
}



