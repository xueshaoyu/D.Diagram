

using D.Diagram.DrawingBox;
using System.ComponentModel.DataAnnotations;


namespace D.Diagram.Presenter.Workflow
{
    [Display(Name = "工作流程图", GroupName = "流程图", Order = 9)]
    public class WorkWorkflow : WorkflowBase
    {
        public WorkWorkflow()
        {
            this.LinkDrawer = new BrokenLinkDrawer();
            //this.NodeGroups = NodeFactory.GetNodeGroups(DiagramType.AuditWorkflow)?.ToObservable();
        }
    }
}
