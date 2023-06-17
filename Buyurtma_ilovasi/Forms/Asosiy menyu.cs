using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buyurtma_ilovasi.Forms
{
    public partial class Asosiy_menyu : Form
    {
        public string chair_name= "";
        public Asosiy_menyu()
        {
            InitializeComponent();
        }
      
        private void Btn_Salat_Click(object sender, EventArgs e)
        {
            Salatlar slt = new Salatlar();
            this.Hide();
            slt.ShowDialog();
            txt_qabul.Text += slt.OrderedSalads;
            if (txt_narx.Text.Length > 3)
            {
                int n = int.Parse(txt_narx.Text) + slt.summa;
                txt_narx.Text = n.ToString();
            }
            else if(slt.summa>0)
            {
                txt_narx.Text = slt.summa.ToString();
            }
            this.Show(); 
        }

        private void Btn_Taom_Click(object sender, EventArgs e)
        {
            Taomlar_menyu taomlar = new Taomlar_menyu();
            this.Hide();
            taomlar.ShowDialog();
            txt_qabul.Text += taomlar.OrderedMeals;
            if (txt_narx.Text.Length > 0)
            {
                int n = int.Parse(txt_narx.Text) + taomlar.summa;
                txt_narx.Text = n.ToString();
            }
            else if(taomlar.summa > 0)
            {
                txt_narx.Text = taomlar.summa.ToString();
            }
            this.Show();
        }

        private void Btn_Ichimlik_Click(object sender, EventArgs e)
        {
            Ichimliklar ichm = new Ichimliklar();
            this.Hide();
            ichm.ShowDialog();
            txt_qabul.Text += ichm.orderedDringks;
            if (txt_narx.Text.Length > 0)
            {
                int n = int.Parse(txt_narx.Text) + ichm.summa;
                txt_narx.Text = n.ToString();
            }
            else if (ichm.summa > 0)
            {
                txt_narx.Text = ichm.summa.ToString();
            }
            this.Show();
        }

        private void Btn_Shirinlik_Click(object sender, EventArgs e)
        {
            Shirinliklar shrn = new Shirinliklar();
            this.Hide();
            shrn.ShowDialog();
            txt_qabul.Text += shrn.orderedCakes;
            if (txt_narx.Text.Length > 0)
            {
                int n = int.Parse(txt_narx.Text) + shrn.summa;
                txt_narx.Text = n.ToString();
            }
            else if (shrn.summa > 0)
            {
                txt_narx.Text = shrn.summa.ToString();
            }
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_qabul.Text = string.Empty;
            txt_narx.Text= string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txt_narx.Text != string.Empty)
            {
                MessageBox.Show($"Siz {txt_narx.Text} so'mlik xarid amalga oshirdingiz!",
                                "Warning!",
                                MessageBoxButtons.OK);
                MainForm1.check = true;
                MainForm1.price = txt_narx.Text;
                MainForm1.products = txt_qabul.Text;
            }
            else
            {
                MessageBox.Show("Hech narsa buyurtma qilmadingiz!");
            }
            txt_qabul.Text = string.Empty;
            txt_narx.Text = string.Empty;
            this.Close();
        }


        private void Asosiy_menyu_Load(object sender, EventArgs e)
        {
            lbl_stol.Text = chair_name;
        }

    }
}
