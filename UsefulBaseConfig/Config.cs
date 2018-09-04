using System.Collections.Generic;
using SimpleMethods.UsefulBaseConfig.Theme;

namespace SimpleMethods.UsefulBaseConfig
{
    public sealed class Config
    {
        private static Config _instance = new Config();
        public static Config Instance
        {
            get { return _instance; }
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

        public readonly List<ITheme> themeColors = new List<ITheme>
        {
            new NormalTheme(),
            new RedTheme(),
        };
    }
}
