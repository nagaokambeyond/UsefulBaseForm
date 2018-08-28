using System.Collections.Generic;
using System.Drawing;

namespace UsefulBaseForm
{
    public class Config
    {
        private static Config _instance = new Config();
        public static Config Instance
        {
            get { return _instance; }
        }
        private Color _foundBackColor = Color.Blue;
        public Color FoundBackColor {
            get
            {
                return _foundBackColor;
            }
            set
            {
                _foundBackColor = value;
            }
        }
        private ITheme _themeColor = new NormalTheme();
        public ITheme ThemeColor
        {
            get
            {
                return _themeColor;
            }
            set
            {
                _themeColor = value;
            }
        }

        public List<ITheme> themeColors = new List<ITheme>
        {
            new NormalTheme(),
            new RedTheme(),
        };
    }
}
