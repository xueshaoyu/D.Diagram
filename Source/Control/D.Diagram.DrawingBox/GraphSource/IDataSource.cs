

using System.Collections.Generic;

namespace D.Diagram.DrawingBox
{
    public interface IDataSource<NodeDataType, LinkDataType>
    {
        List<NodeDataType> GetNodeType();

        List<LinkDataType> GetLinkType();
    }
}
