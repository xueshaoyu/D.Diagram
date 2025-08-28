

using D.Diagram.DrawingBox;
using System.ComponentModel.DataAnnotations;


namespace D.Diagram.Presenter.Workflow
{
    [Display(Name = "IDEF图", GroupName = "流程图", Order = 7)]
    public class IDEFWorkflow : WorkflowBase
    {
        public IDEFWorkflow()
        {
            this.LinkDrawer = new BrokenLinkDrawer();
            //this.NodeGroups = NodeFactory.GetNodeGroups(DiagramType.AuditWorkflow)?.ToObservable();
        }
    }
}
