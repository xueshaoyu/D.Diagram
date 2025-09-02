// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control

namespace D.Diagram.DrawingBox
{
    /// <summary>
    /// 流程执行结果
    /// </summary>
    public class FlowableResult : IFlowableResult
    {
        public FlowableResult(string message)
        {
            this.Message = message;
        }
        public string Message { get; }

        public FlowableResultState State { get; set; }
    }

    /// <summary>
    /// 有返回值的流程执行结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FlowableResult<T> : FlowableResult
    {
        public FlowableResult(T t) : base(null)
        {
            this.State = FlowableResultState.OK;
            this.Value = t;
        }
        public FlowableResult(T t, string message) : base(message)
        {
            this.State = FlowableResultState.OK;
            this.Value = t;
        }
        public T Value { get; set; }
    }
}
