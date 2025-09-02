

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
