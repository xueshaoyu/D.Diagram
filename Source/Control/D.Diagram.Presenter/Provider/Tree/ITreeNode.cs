// Copyright © 2024 By HeBianGu(QQ:908293466) https://github.com/HeBianGu/WPF-Control

using System.Windows;

namespace D.Diagram.Presenter
{
    public interface ITreeNode
    {
        bool IsExpanded { get; set; }
        bool? IsChecked { get; set; }
        Visibility Visibility { get; set; }
    }
}
