// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control


// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control

namespace D.Diagram.Presenter
{
    public interface IModelBindable<T> : IModelBindable
    {
        T Model { get; set; }
        double Value { get; set; }
        bool Visible { get; set; }
    }
}
