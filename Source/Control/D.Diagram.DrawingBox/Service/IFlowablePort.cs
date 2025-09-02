

using System.Threading.Tasks;

namespace D.Diagram.DrawingBox
{
    public interface IFlowablePort : IFlowable
    {
        IFlowableResult Invoke(Part previors, Port current);
        Task<IFlowableResult> InvokeAsync(Part previors, Port current);
        Task<IFlowableResult> TryInvokeAsync(Part previors, Port current);
    }
}
