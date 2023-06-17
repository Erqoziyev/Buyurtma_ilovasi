using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buyurtma_ilovasi.Forms
{
    public partial class Salatlar : Form
    {
        List<string> lst = new List<string>();
        public int summa ;
        public string OrderedSalads = "";

        public Salatlar()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
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
                salat_box.Text = "";
            }
            foreach (var item in lst)
            {
                salat_box.Text += item + "  ";
            }

            if (btn.Text == "Mevali salad")
            {
                summa += 15000;
            }
            else if (btn.Text == "Oliviya salad")
            {
                summa += 15000;
            }
            else if (btn.Text == "Makajo'xori salad")
            {
                summa += 14000;
            }
            else if (btn.Text == "Karam saladi")
            {
                summa += 10000;
            }
            else if (btn.Text == "Koreys saladi")
            {
                summa += 10000;
            }
            else if (btn.Text == "Qizilchali salad")
            {
                summa += 15000;
            }
            else if (btn.Text == "Arab saladi")
            {
                summa += 14000;
            }
            else if (btn.Text == "Baliqli salad")
            {
                summa += 18000;
            }
        }

        private void Btn_asosiy_menu_Click(object sender, EventArgs e)
        {
            OrderedSalads = salat_box.Text;
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            salat_box.Text = string.Empty;
            summa = 0;
            lst.Clear();
        }
    }
}
