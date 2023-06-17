using Buyurtma_ilovasi.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Buyurtma_ilovasi
{
    public partial class MainForm1 : Form
    {
        public ToolStripMenuItem stol_btn { get; set; }
        public Dictionary<string, string> dct_price = new Dictionary<string, string>();
        public Dictionary<string, string> dct_product = new Dictionary<string, string>();
        public static string price = string.Empty;
        public static string products = string.Empty;
        public static bool check=false;
        public MainForm1()
        {
            InitializeComponent();
        }
        public List<string> list = new List<string>();
        private void Stol_1_Click(object sender, EventArgs e)
        {
            stol_btn = (ToolStripMenuItem)(sender);
            if (stol_btn.ForeColor == Color.Red)
            {
                panel1.Visible = true;
                panel2.Visible = true;
                lbl_narx_tolash.Text = dct_price[stol_btn.Text];
                dct_price.Remove(stol_btn.Text);
                maxsulot_txt_box.Text = dct_product[stol_btn.Text];
                dct_product.Remove(stol_btn.Text);
            }
            else
            {
                Asosiy_menyu asosiy = new Asosiy_menyu();
                this.Hide();
                string text = stol_btn.Text;
                asosiy.chair_name = text;
                asosiy.ShowDialog();
            }
            
            if (check)
            {
                stol_btn.ForeColor = Color.Red;
                dct_price.Add(stol_btn.Text, price);
                dct_product.Add(stol_btn.Text, products);
                check = false;
            }
            this.Show();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel2.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbl_narx_tolash.Text==check_price_txt.Text) 
            {
                MessageBox.Show("To'landi. Tashrifingiz uchun rahmat 👌");
                stol_btn.ForeColor = Color.Black;
                check_price_txt.Text = string.Empty;
                maxsulot_txt_box.Text = string.Empty;

                panel1.Visible = false;
                panel2.Visible= false;
            }
            else
            {
                MessageBox.Show("To'lanmadi. Narxni tekshirib ko'ring ‼️");
                check_price_txt.Text = string.Empty;
                maxsulot_txt_box.Text = string.Empty;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
