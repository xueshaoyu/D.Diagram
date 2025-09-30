
namespace D.Diagram.Presenter.Workflow
{
    /// <summary>
    /// 工作流节点抽象类
    /// </summary>
    public abstract class WorkflowNodeBase : GeometryNodeDataBase, IWorkflowNode
    {
    }

    public interface IWorkflowNode
    {
    }
    public interface IWorkflowNode<T>: IWorkflowNode
    {
        T Result { get; set; }
    }
    public abstract class WorkflowNodeBase<T>: WorkflowNodeBase,IWorkflowNode<T>
    {
        public T Result { get; set; }
    }
}
