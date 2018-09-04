namespace Example
{
    public partial class Form1 : SimpleMethods.UsefulBaseForm.UsefulBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var f2 = new Form2();
            var f3 = new Form3();
            var f4 = new Form4();
            f2.Show();
            f3.Show();
            f4.Show();
        }
    }
}
