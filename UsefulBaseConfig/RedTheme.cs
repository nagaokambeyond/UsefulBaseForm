using System.Drawing;

namespace UsefulBaseForm
{
    public class RedTheme : ITheme
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
        public override string ToString()
        {
            return "Red";
        }
    }
}
