using System;
using System.Windows.Forms;

namespace SimpleMethods.UsefulBaseForm
{
    internal partial class WindowList : System.Windows.Forms.Form
    {
        private static WindowList _instance = new WindowList();
        public static WindowList Instance
        {
            get { return _instance; }
        }

        public WindowList()
        {
            InitializeComponent();
        }

        private void WindowList_Shown(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Form frm in Application.OpenForms)
            {
                if (Text == frm.Text) continue;
                listBox1.Items.Add(frm.Text);
            }
        }
    }
}
