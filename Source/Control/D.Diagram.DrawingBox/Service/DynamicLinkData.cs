

namespace D.Diagram.DrawingBox
{
    public class DynamicLinkData : DefaultLinkData, IFlowable
    {
        public bool UseInfoLogger { get; set; }

        public FlowableState State { get; set; }

        public void Clear()
        {

        }
        /// <summary>
        /// 重置
        /// </summary>
        public virtual void Reset()
        {

        }
        public virtual void Dispose()
        {

        }
    }
}
