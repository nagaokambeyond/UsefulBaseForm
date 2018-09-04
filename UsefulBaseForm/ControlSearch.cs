using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SimpleMethods.UsefulBaseConfig;

namespace SimpleMethods.UsefulBaseForm
{
    internal sealed partial class ControlSearch : System.Windows.Forms.Form
    {
        private static ControlSearch _instance = new ControlSearch();
        public static ControlSearch Instance
        {
            get { return _instance; }
        }
        private List<Tuple<Control, Color>> saveControls;
        private List<Control> foundControls;
        private string word;
        private System.Windows.Forms.Form _parentForm;
        public new System.Windows.Forms.Form ParentForm
        {
            set
            {
                if(_parentForm != value)
                {
                    Reset();
                    _parentForm = value;
                }
            }
        }

        public ControlSearch()
        {
            InitializeComponent();
            foundControls = new List<Control>();
            saveControls = new List<Tuple<Control, Color>>();
        }

        private void Clear()
        {
            word = string.Empty;
            textBox1.Clear();
            Reset();
        }

        private void Reset()
        {
            foundControls.Clear();
            foreach(var ctl in saveControls)
            {
                ctl.Item1.BackColor = ctl.Item2; 
            }
            saveControls.Clear();
        }

        private void AddList(Control.ControlCollection  controls)
        {
            foreach(Control ctl in controls)
            {
                if (ctl is GroupBox)
                {
                    var grp = ctl as GroupBox;
                    AddList(grp.Controls);
                }
                else if(ctl is TabControl)
                {
                    var tab = ctl as TabControl;
                    foreach(TabPage page in tab.TabPages)
                    {
                        AddList(page.Controls);
                    }
                }
                else if(ctl is Panel)
                {
                    var pnl = ctl as Panel;
                    AddList(pnl.Controls);
                }
                else if (ctl is DateTimePicker)
                {
                    var dtp = ctl as DateTimePicker;
                    if (dtp.Value.ToString().Contains(word)) foundControls.Add(dtp);
                }
                else if (ctl is ListBox)
                {
                    var lst = ctl as ListBox;
                    if (lst.Items.ToString().ToLower().Contains(word.ToLower())) foundControls.Add(lst);
                }
                else if ((ctl is TextBox) || (ctl is CheckBox) || (ctl is ComboBox))
                {
                    if (ctl.Text.ToLower().Contains(word.ToLower())) foundControls.Add(ctl);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (word == textBox1.Text) return;
            Reset();
            word = textBox1.Text;
            if (string.IsNullOrEmpty(word)) return;
            AddList(_parentForm.Controls);
            foreach(var ctl in foundControls)
            {
                saveControls.Add(Tuple.Create<Control,Color>(ctl, ctl.BackColor));
                ctl.BackColor = Config.Instance.ThemeColor.FoundBackColor;
            }
        }

        private void ControlSearch_VisibleChanged(object sender, EventArgs e)
        {
            timer1.Enabled = Visible; 
        }

        private void ControlSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;
            Clear();
        }
    }
}
