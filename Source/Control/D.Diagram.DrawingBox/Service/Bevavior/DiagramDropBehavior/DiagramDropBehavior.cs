// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control



using Microsoft.Xaml.Behaviors;
using System;
using System.Windows;

namespace D.Diagram.DrawingBox
{
    /// <summary> Diagram接收放下的操作 </summary>
    public abstract class DiagramDropBehaviorBase : Behavior<Diagram>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.Drop += AssociatedObject_Drop;
        }
        // 添加状态标记和时间戳防止重复处理
        private bool _isProcessingDrop = false;
        private DateTime _lastDropTime = DateTime.MinValue;
        private const int MIN_DROP_INTERVAL = 200; // 最小拖放处理间隔(毫秒)
        
        private void AssociatedObject_Drop(object sender, DragEventArgs e)
        {
            // 防止重入和快速重复处理
            var now = DateTime.Now;
            if (_isProcessingDrop || (now - _lastDropTime).TotalMilliseconds < MIN_DROP_INTERVAL)
            {
                Debug.WriteLine($"忽略AssociatedObject_Drop");
                e.Handled = true;
                return;
            }
            try
            {
                _isProcessingDrop = true;
                _lastDropTime = now;
                IDragAdorner adorner = e.Data.GetData("DragGroup") as IDragAdorner;
    
                if (adorner == null) return;
    
                Point offset = adorner.Offset;
    
                Point location = e.GetPosition(this.AssociatedObject);
    
                ICloneable obj = ((adorner as System.Windows.Documents.Adorner).AdornedElement as FrameworkElement).DataContext as ICloneable;
    
                if (obj == null)
                {
                    throw new ArgumentException("没有实现ICloneable接口");
                }
    
                //if (this.AssociatedObject.NodesSource is IList collection)
                //{
                object content = obj.Clone();
    
                Node node = this.Create(content as INodeData);
    
                node.Content = content;
    
                node.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                node.Location = new Point(location.X - offset.X + (node.DesiredSize.Width / 2), location.Y - offset.Y + (node.DesiredSize.Height / 2));
    
    
                //collection.Add(node);
    
                //this.AssociatedObject.RefreshData();
    
                this.AssociatedObject.AddNode(node);
                //}
                }
               finally
               {
                   // 确保状态重置
                   _isProcessingDrop = false;
               }

        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Drop -= AssociatedObject_Drop;
        }

        protected abstract Node Create(INodeData data);

    }
}
