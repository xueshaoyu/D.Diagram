

using System.Threading.Tasks;

namespace D.Diagram.DrawingBox
{
    public interface IFlowableLink : IFlowable
    {
        IFlowableResult Invoke(Part previors, Link current);
        Task<IFlowableResult> InvokeAsync(Part previors, Link current);
        Task<IFlowableResult> TryInvokeAsync(Part previors, Link current);
        bool IsMatchResult(FlowableResult flowableResult);

        /// <summary>
        /// 执行结果
        /// </summary>
        IFlowableResult Result { get; set; }
    }
}
