using System.Drawing;

namespace SimpleMethods.UsefulBaseConfig
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