using System.Windows.Forms;

namespace UsefulBaseForm
{
    public partial class UsefulBaseForm : Form
    {
        public UsefulBaseForm()
        {
            InitializeComponent();
        }

        private void UsefulBaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
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

            }
        }
    }
}
