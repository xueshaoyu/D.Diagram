

namespace D.Diagram.DrawingBox
{
    public enum FlowableState
    {
        Ready = 0,
        Wait,
        Running,
        Success,
        Error,
        Canceling,
        Stopped,
        Pause
    }
}
