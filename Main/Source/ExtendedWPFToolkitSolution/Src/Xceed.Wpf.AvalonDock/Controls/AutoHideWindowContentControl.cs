using System.Windows;
using System.Windows.Controls;

namespace Xceed.Wpf.AvalonDock.Controls
{
    public class AutoHideWindowContentControl : ContentControl
    {
        static AutoHideWindowContentControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AutoHideWindowContentControl), new FrameworkPropertyMetadata(typeof(AutoHideWindowContentControl)));
        }
    }
}
