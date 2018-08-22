using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UsefulBaseForm
{
    internal sealed partial class ControlSearch : Form
    {
        private static ControlSearch _instance = new ControlSearch();
        public static ControlSearch Instance
        {
            get { return _instance; }
        }
        private List<Tuple<Control, Color>> blink;
        private List<Control> list;
        private string word;
        private Form _parentForm;
        public new Form ParentForm
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
            list = new List<Control>();
            blink = new List<Tuple<Control, Color>>();
        }

        private void Clear()
        {
            word = string.Empty;
            textBox1.Clear();
            Reset();
        }

        private void Reset()
        {
            list.Clear();
            foreach(var ctl in blink)
            {
                ctl.Item1.BackColor = ctl.Item2; 
            }
            blink.Clear();
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
                    foreach(TabPage whi in tab.TabPages)
                    {
                        AddList(whi.Controls);
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
                    if (dtp.Value.ToString().Contains(word)) list.Add(dtp);
                }
                else if (ctl is ListBox)
                {
                    var lst = ctl as ListBox;
                    if (lst.Items.ToString().ToLower().Contains(word.ToLower())) list.Add(lst);
                }
                else if ((ctl is TextBox) || (ctl is CheckBox) || (ctl is ComboBox))
                {
                    if (ctl.Text.ToLower().Contains(word.ToLower())) list.Add(ctl);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (word == textBox1.Text) return;
            word = textBox1.Text;
            Reset();
            if (string.IsNullOrEmpty(word)) return;
            AddList(_parentForm.Controls);
            foreach(var ctl in list)
            {
                blink.Add(Tuple.Create<Control,Color>(ctl, ctl.BackColor));
                ctl.BackColor = Color.Blue;
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
