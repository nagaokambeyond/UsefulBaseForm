using System.Drawing;

namespace UsefulBaseConfig.Theme
{
    public sealed class NormalTheme : ITheme
    {
        public Color FormBackColor
        {
            get
            {
                return SystemColors.Control;
            }
        }
        public Color ControlFocusBackColor
        {
            get
            {
                return Color.Yellow;
            }
        }
        public Color ControlBackColor
        {
            get
            {
                return SystemColors.Window;
            }
        }
        public Color ControlForeColor
        {
            get
            {
                return SystemColors.WindowText;
            }
        }

        public Color FoundBackColor
        {
            get
            {
                return Color.Blue;
            }
        }

        public override string ToString()
        {
            return "Normal";
        }
    }
}
