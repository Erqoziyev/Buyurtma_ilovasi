using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buyurtma_ilovasi.Forms
{
    public partial class Taomlar_menyu : Form
    {
        List<string> lst = new List<string>();
        public int summa ;
        public string OrderedMeals = "";
        public Taomlar_menyu()
        {
            InitializeComponent();
        }

        private void Btn_palov_Click(object sender, EventArgs e)
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
                taom_box.Text = "";
            }
            foreach (var item in lst)
            {
                taom_box.Text += item + "  ";
            }
 

            if (btn.Text == "Palov")
            {
                summa += 25000;
            }
            else if (btn.Text == "Sho'rva")
            {
                summa += 20000;
            }
            else if (btn.Text == "Lag'mon")
            {
                summa += 21000;
            }
            else if (btn.Text == "Qovurma lag'mon")
            {
                summa += 20000;
            }
            else if (btn.Text == "Mastava")
            {
                summa += 15000;
            }
            else if (btn.Text == "Qovurdoq")
            {
                summa += 30000;
            }
            else if (btn.Text == "Kabob")
            {
                summa += 14000;
            }
            else if (btn.Text == "Chuchvara")
            {
                summa += 20000;
            }
        }


        private void Btn_asosiy_menu_Click(object sender, EventArgs e)
        {
            OrderedMeals = taom_box.Text;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            taom_box.Text= string.Empty;
            summa = 0;
            lst.Clear();
        }
    }
}
