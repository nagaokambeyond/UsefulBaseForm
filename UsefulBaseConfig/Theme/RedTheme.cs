using System.Drawing;

namespace SimpleMethods.UsefulBaseConfig.Theme
{
    public sealed class RedTheme : ITheme
    {
        public Color ControlBackColor
        {
            get
            {
                return Color.DarkRed;
            }
        }

        public Color ControlFocusBackColor
        {
            get
            {
                return Color.Gray;
            }
        }

        public Color ControlForeColor
        {
            get
            {
                return Color.DarkSeaGreen;
            }
        }

        public Color FormBackColor
        {
            get
            {
                return Color.DarkRed;
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
            return "Red";
        }
    }
}
