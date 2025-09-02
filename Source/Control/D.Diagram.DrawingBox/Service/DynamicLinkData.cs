

namespace D.Diagram.DrawingBox
{
    public class DynamicLinkData : DefaultLinkData, IFlowable
    {
        public bool UseInfoLogger { get; set; }

        public FlowableState State { get; set; }

        public void Clear()
        {

        }
        public virtual void Dispose()
        {

        }
    }
}
