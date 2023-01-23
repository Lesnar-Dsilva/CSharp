using System.Text.RegularExpressions;
namespace Cafe_Billing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static DateTime Now = DateTime.Now;
        static Form1 form1 = new Form1();
        static Form2 form2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Date.Text = Now.ToString("d");
            Time.Text = Now.ToString("h:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            Date.Text = Now.ToString("d");
            Time.Text = Now.ToString("h:mm:ss tt");
        }
        static Dictionary<String, String> map = new Dictionary<String, String>() { { "cbL", "Latte: £2.25" }, { "cbM", "Mocha: £2.65" }, { "cbMa", "Macchiato: £3.00" }, { "cbC", "Cappucino: £2.60" }, { "cbA", "Americano: £1.95" }, { "cbE", "Espresso: £1.50" }, { "cbF", "Flat White: £2.50" }, { "cbCo", "Cortado: £2.50" }, { "cbSE", "Shaken Espresso: 1.90" }, { "cbFC", "Filter Coffee: £1.55" }, { "cbCM", "Caffè Misto: £1.95" }, { "cbCB", "Cold Brew: £2.50" }, { "cbCBL", "Cold Brew Latte: £2.75" }, { "cbNCB", "Nitro Cold Brew: £3.00" }, { "cbNL", "Nitro Latte: £2.65" }, { "cbNC", "Nitro Cappuccino: £2.60" }, { "cbCT", "Chai Tea: £2.75" }, { "cbMCT", "Mint Citrus Tea: £2.80" }, { "cbEGT", "Earl Grey Tea: £2.70" }, { "cbIBT", "Iced Black Tea: £2.30" }, { "cbIBTL", "Iced Black Tea Lemonade: £2.40" }, { "cbIGT", "Iced Green Tea: £2.30" }, { "cbIGTL", "Iced Green Tea Lemonade: £2.60" }, { "cbPIT", "Peach Iced Tea: £2.40" }, { "cbLIT", "Lemon Iced Tea: £2.40" }, { "cbCHC", "Classic Hot Chocolate: £2.50" }, { "cbWHC", "White Hot Chocolate: £2.65" }, { "cbW7", "Water 750ml: £1" }, { "cbW5", "Water 500ml: £0.75" }, { "cbW5S", "Water 500ml Sparkling: £1" }, { "cbCW4", "Coconut Water 400ml: £1" }, { "cbBC", "Butter Croissant: £2.00" }, { "cbPC", "Pain au Chocolat: £2.15" }, { "cbCTwist", "Chocolate Twist: £2.30" }, { "cbAC", "Almond Croissant: £2.70" }, { "cbBMBS", "Beyond Meat® Breakfast Sandwich: £5.00" }, { "cbSBR", "Smoked Bacon Roll: £4.10" }, { "cbTSS", "Traditional Sausage Sandwich: £4.20" }, { "cbADBW", "All Day Breakfast Wrap: £4.90" }, { "cbHCC", "Ham & Cheese Croissant: £4.10" }, { "cbIRS", "Iced Raspberry Swirl: £3.00" }, { "cbWCRB", "White Chocolate & Raspberry Blondie: £2.20" }, { "cbSM", "S'more Muffin: £2.75" }, { "cbTCC", "Triple Chocolate Cookie: £2.25" }, { "cbCS", "Cinnamon Swirl: £2.80" }, { "cbCCB", "Cookies & Cream Brownie: £2.30" }, { "cbBCC", "Birthday Cake Cookie: £2" }, { "cbCCC", "Chocolate Chunk Cookie: £2.20" }, { "cbLL", "Lemon Loaf: £2.80" }, { "cbLM", "Lemon Muffin: £2.40" }, { "cbMPTP", "Mozzarella & Plum Tomato Pizzetta: £6.60" }, { "cbCRPP", "Chorizo & Red Pepper Pizzetta: £6.60" }, { "cbCMPF", "Chicken, Mozzarella & Pesto Focaccia: £5.90" }, { "cbSTCCS", "Smoked Turkey & Cheddar Cheese Sandwich: £4.40" }, { "cbTS", "Tun(a) Sandwich: £3.29" }, { "cbHHCT", "Hickory Ham & Cheese Toastie: £5.20" }, { "cbGFHCP", "Gluten Free Ham & Cheese Panini: £2.40" } };
        static List<String> text = new List<string>();
        public String d(Object sender)
        {
            CheckBox c = sender as CheckBox;
            return map[c.Name];
        }
        static int n;
        static double cost;

        public void c(object sender)
        {
            CheckBox c = sender as CheckBox;
            form2.ShowDialog();
            form2.NumericUpDown1.Value = 1;
            n = Convert.ToInt32(form2.NumericUpDown1.Value);
            if (n != 0)
            {
                text.Add(d(sender).ToString() + $" Quantity:{n}");
            }
            cost += Convert.ToDouble(Regex.Match(d(sender).ToString().Split(":")[1], @"\d+\.*\d*").Value);
            textBox1.Text = String.Join($"\r\n", text);
            textBox2.Text = $"£ {cost.ToString()}";
        }
        public void cc(object sender)
        {
            text.Remove(d(sender).ToString() + $" Quantity:{n}");
            textBox1.Clear();
            textBox1.Text = String.Join($"\r\n", text.Where(s => !string.IsNullOrEmpty(s)));
            cost -= Convert.ToDouble(Regex.Match(d(sender).ToString(), @"\d+\.*\d*").Value);
            textBox2.Text = $"£ {cost.ToString("0.00")}";
        }
        public void cbL_CheckedChanged_1(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbM_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbMa_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbE_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbFlat_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCo_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbSE_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbMisto_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCBL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbNCB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbNL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbNC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbMCT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbEGT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbIBT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbIBTL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbIGT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbIGTL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbPIT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbLIT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCHC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbWHC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbW7_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbW5_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbW5S_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCW4_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbBC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbPC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCTwist_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbAC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbBMBS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbSBR_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbTSS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbADBW_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbHCC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbIRS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbWCRB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbSM_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbTCC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbCS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbCCB_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbBCC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbCCC_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbLL_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbLM_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void cbMPTP_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void CRPP_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void cbCMPF_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }

        }

        private void STCCS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void TS_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void HHCT_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void GFHCP_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                c(sender);
                if (n == 0)
                {
                    cbL.Checked = false;
                }
            }
            else
            {
                cc(sender);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            foreach (Control c in tabPage2.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            cost = 0;
        }
        public void lblClick(object sender)
        {
            Label l = sender as Label;
            foreach (Control c in tabPage1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ch = c as CheckBox;
                    if (c.Name == l.Name.Replace("lbl", "cb"))
                    {
                        if (ch.Checked)
                        {
                            ch.Checked = false;
                        }
                        else
                        {
                            ch.Checked = true;
                        }

                    }
                }
            }
            foreach (Control c in tabPage2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ch = c as CheckBox;
                    if (c.Name == l.Name.Replace("lbl", "cb"))
                    {
                        if (ch.Checked)
                        {
                            ch.Checked = false;
                        }
                        else
                        {
                            ch.Checked = true;
                        }

                    }
                }
            }
        }
        private void lblL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblM_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblMa_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblE_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblF_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCo_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblSE_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblFilter_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblMisto_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCB_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCBL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblNCB_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblNL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblNC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblMCT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblEGT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblIBT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblIBTL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblIGT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblIGTL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblPIT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblLIT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCHC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblWHC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblW7_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblW5_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblW5S_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCW4_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblBC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblPC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCTwist_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblAC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void BMBS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblSBR_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblTSS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblADBW_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblHCC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblIRS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblWCRS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblSM_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblTCC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCCB_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblBCC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCCC_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblLL_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblLM_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblMPTP_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCRPP_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblCMPF_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblSTCCS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblTS_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblHHCT_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }

        private void lblGFGCP_Click(object sender, EventArgs e)
        {
            lblClick(sender);
        }
    }
}

//ISSUES
/*
The most prominent issue was repetition throughout the program, I found new ways to reduce this by using functions, regular expressions or loops.
The first issue I encountered was how I was going to handle the checkboxes because I didn't want to repeat myself for each checkbox, then came the issue of the labels for the accessibility reason to be buttons as well, but to make it more challenging I used labels. The interesting thing I discovered was that I can use the "as" keyword to pass a object as another class and then access the methods/properties for those classes. Functions seemed to solve the checkbox and label issues.

I also solved the regex issue with the Water bottles using numbers for their measurements in liquids contained, I split the value from the dictionary by finding the colon(:) to be the most common character rather than the space in all of them, and then used regex to extract the digits from the array.
 */

//FINAL THOUGHTS

/*
 I understand I could have shortened some syntax, but I wanted to display my full potential on completion of this project in C#, because finding shortcuts can work, but fully understanding the syntax is more important to me.

 I finished the project on 31th July 2022, it took 6 days in total to complete this project. 12 hours in total, 2 hours/day.
 */

