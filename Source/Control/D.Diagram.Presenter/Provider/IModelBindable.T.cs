




namespace D.Diagram.Presenter
{
    public interface IModelBindable<T> : IModelBindable
    {
        T Model { get; set; }
        double Value { get; set; }
        bool Visible { get; set; }
    }
}
