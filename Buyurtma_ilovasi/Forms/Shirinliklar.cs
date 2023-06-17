using System.Collections.Generic;
using System.Windows.Forms;

namespace Buyurtma_ilovasi.Forms
{
    public partial class Shirinliklar : Form
    {
        List<string> lst = new List<string>();
        public int summa ;
        public string orderedCakes = string.Empty;
        public Shirinliklar()
        {
            InitializeComponent();
        }

        private void Btn_pirog_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (lst.Count == 0)
            {
                lst.Add(btn.Text);
            }
            else
            {
                bool check = true;
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].StartsWith(btn.Text))
                    {
                        check = false;
                        int a = 0;
                        string b = lst[i][lst[i].Length - 2].ToString();
                        bool n = int.TryParse(b, out a);
                        if (n)
                        {
                            a++;
                            lst[i] = btn.Text + $"({a})";
                        }
                        else
                        {
                            lst[i] = btn.Text + "(2)";
                        }
                    }
                }
                if (check)
                {
                    lst.Add(btn.Text);
                }
                shirinlik_box.Text = "";
            }
            foreach (var item in lst)
            {
                shirinlik_box.Text += item + "  ";
            }

            if (btn.Text== "Qulupnayli pirog")
            {
                summa += 5000;
            }
            else if (btn.Text== "Shkoladlli tort")
            {
                summa += 20000;
            }
            else if (btn.Text == "Paxlava")
            {
                summa +=15000;
            }
            else if (btn.Text == "Olchali pirog")
            {
                summa +=15000;
            }
            else if (btn.Text == "Rulet")
            {
                summa +=5000;
            }
            else if (btn.Text == "Keks")
            {
                summa +=6000;
            }
            else if (btn.Text == "Medovik")
            {
                summa +=17000;
            }
            else if (btn.Text == "Vafli")
            {
                summa +=4000;
            }
        }

        private void btn_asosiy_menu_Click(object sender, System.EventArgs e)
        {
            orderedCakes = shirinlik_box.Text;
            this.Close();
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            shirinlik_box.Text = string.Empty;
            summa = 0;
            lst.Clear();
        }
    }
}
