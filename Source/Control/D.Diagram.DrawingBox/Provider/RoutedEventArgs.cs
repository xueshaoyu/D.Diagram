

using System.Windows;

namespace D.Diagram.DrawingBox
{
    public class RoutedEventArgs<T> : RoutedEventArgs
    {
        public RoutedEventArgs(T entity)
        {
            Entity = entity;
        }

        public RoutedEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source)
        {
        }
        public RoutedEventArgs(RoutedEvent routedEvent, object source, T entity) : base(routedEvent, source)
        {
            Entity = entity;
        }


        public T Entity { get; set; }
    }
}
