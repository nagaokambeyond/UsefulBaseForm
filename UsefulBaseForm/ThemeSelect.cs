using System;
using UsefulBaseConfig;

namespace UsefulBaseForm
{
    internal sealed partial class ThemeSelect : System.Windows.Forms.Form
    {
        private static ThemeSelect _instance = new ThemeSelect();
        public static ThemeSelect Instance
        {
            get { return _instance; }
        }
        public ThemeSelect()
        {
            InitializeComponent();
            foreach(ITheme theme in Config.Instance.themeColors)
            {
                comboBox1.Items.Add(theme.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            Config.Instance.ThemeColor = Config.Instance.themeColors[comboBox1.SelectedIndex];
            Close();
        }
    }
}
