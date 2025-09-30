

namespace D.Diagram.DrawingBox
{
    /// <summary>
    /// 流程执行结果状态
    /// </summary>
    public enum FlowableResultState
    {
        /// <summary>
        /// 未执行
        /// </summary>
        None = 0,
        /// <summary>
        /// 结果正常
        /// </summary>
        OK = 1,
        //Warn,
        /// <summary>
        /// 结果错误
        /// </summary>
        Error
    }
}
