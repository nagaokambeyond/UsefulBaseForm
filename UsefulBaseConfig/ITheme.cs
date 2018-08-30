using System.Drawing;

namespace UsefulBaseConfig
{
    public interface ITheme
    {
        Color ControlBackColor { get; }
        Color ControlFocusBackColor { get; }
        Color ControlForeColor { get; }
        Color FormBackColor { get; }
        Color FoundBackColor { get; }
    }
}