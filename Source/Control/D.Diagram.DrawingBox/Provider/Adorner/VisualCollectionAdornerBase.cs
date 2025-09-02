

using System.Windows;
using System.Windows.Media;

namespace D.Diagram.DrawingBox
{
    public abstract class VisualCollectionAdornerBase : AdornerBase
    {
        protected VisualCollection _visualCollection;

        public VisualCollectionAdornerBase(UIElement adornedElement) : base(adornedElement)
        {
            _visualCollection = new VisualCollection(this);
        }

        protected override Visual GetVisualChild(int index)
        {
            return _visualCollection[index];
        }
        protected override int VisualChildrenCount
        {
            get
            {
                return _visualCollection.Count;
            }
        }
    }
}
