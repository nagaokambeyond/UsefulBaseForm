using System.Collections.Generic;
using System.Drawing;

namespace UsefulBaseForm
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

        public override string ToString()
        {
            return "Normal";
        }
    }
}
