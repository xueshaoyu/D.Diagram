

namespace D.Diagram.DrawingBox
{
    public interface ILinkData : IData
    {
        string FromNodeID { get; set; }

        string ToNodeID { get; set; }

        string FromPortID { get; set; }

        string ToPortID { get; set; }

        void ApplayStyleTo(ILinkData node);
    }
}
