



using System.ComponentModel;

namespace D.Diagram.DrawingBox
{
    [DisplayName("LocationLayout")]
    [TypeConverter(typeof(DisplayNameConverter))]
    public class LocationLayout : Layout
    {
        /// <summary> 布局点和线 </summary>
        public override void DoLayout(params Node[] nodes)
        {
            foreach (Node node in nodes)
            {
                //  Do ：布局Node
                NodeLayer.SetPosition(node, node.Location);
            }

            //this.UpdateNode(nodes);
        }

        public override void RemoveNode(params Node[] nodes)
        {
            foreach (Node node in nodes)
            {
                node.Delete();
            }
        }

        public override void AddNode(params Node[] nodes)
        {
            this.DoLayout(nodes);
        }
    }
}
