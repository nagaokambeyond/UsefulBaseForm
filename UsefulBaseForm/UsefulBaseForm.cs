using System.Drawing;
using System.Windows.Forms;

namespace UsefulBaseForm
{
    public partial class UsefulBaseForm : Form
    {
        private Color ControlFocusBackColor { get; set; }
        private Color ControlBackColor { get; set; }

        public UsefulBaseForm()
        {
            InitializeComponent();
            SetColors();
        }

        private void UsefulBaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.F)
                {
                    var f = ControlSearch.Instance;
                    f.ParentForm = this;
                    f.ShowDialog();
                }
                else if (e.KeyCode == Keys.W)
                {
                    var f = WindowList.Instance;
                    f.ShowDialog();
                }
                else if (e.KeyCode == Keys.T)
                {
                    var f = ThemeSelect.Instance;
                    f.ShowDialog();
                    SetColors();
                }
            }
        }

        private void SetColors()
        {
            ITheme theme = Config.Instance.ThemeColor;
            BackColor = theme.FormBackColor;
            foreach (Control ctl in Controls)
            {
                ctl.BackColor = theme.ControlBackColor;
                ctl.ForeColor = theme.ControlForeColor;

                if (ctl is TabControl)
                {
                    var tab = ctl as TabControl;
                    foreach(TabPage page in tab.TabPages)
                    {
                        page.BackColor = theme.FormBackColor;
                        foreach (Control ctl2 in page.Controls)
                        {
                            ctl2.BackColor = theme.ControlBackColor;
                            ctl2.ForeColor = theme.ControlForeColor;
                        }
                    }
                }
            }
            ControlFocusBackColor = theme.ControlFocusBackColor;
            ControlBackColor = theme.ControlBackColor;
        }

        private void UsefulBaseForm_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Leave += Control_Leave;
            e.Control.Enter += Control_Enter;
        }

        private void Control_Enter(object sender, System.EventArgs e)
        {
            var ctl = sender as Control;
            ctl.BackColor = ControlFocusBackColor;
        }

        private void Control_Leave(object sender, System.EventArgs e)
        {
            var ctl = sender as Control;
            ctl.BackColor = ControlBackColor;
        }
    }
}
