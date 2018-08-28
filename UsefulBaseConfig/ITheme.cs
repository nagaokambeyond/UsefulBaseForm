using System.Drawing;

namespace UsefulBaseForm
{
    public interface ITheme
    {
        Color ControlBackColor { get; }
        Color ControlFocusBackColor { get; }
        Color ControlForeColor { get; }
        Color FormBackColor { get; }
    }
}