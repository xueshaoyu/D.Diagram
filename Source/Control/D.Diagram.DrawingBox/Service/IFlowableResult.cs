

namespace D.Diagram.DrawingBox
{

    /// <summary>
    /// 流程执行结果接口
    /// </summary>
    public interface IFlowableResult
    {
        string Message { get; }

        FlowableResultState State { get; set; }
    }
}
