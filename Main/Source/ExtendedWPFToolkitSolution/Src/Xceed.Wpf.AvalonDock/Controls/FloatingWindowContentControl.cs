using System.Windows;
using System.Windows.Controls;

namespace Xceed.Wpf.AvalonDock.Controls
{
    public class FloatingWindowContentControl : ContentControl
    {
        static FloatingWindowContentControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FloatingWindowContentControl), new FrameworkPropertyMetadata(typeof(FloatingWindowContentControl)));
        }
    }
}
