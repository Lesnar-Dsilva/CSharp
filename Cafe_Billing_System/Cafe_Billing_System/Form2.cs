namespace Cafe_Billing_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public NumericUpDown NumericUpDown1 = new NumericUpDown();
        public void upDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown1.Value = upDown.Value;
        }
    }
}
