using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Buyurtma_ilovasi.Forms
{
    public partial class Ichimliklar : Form
    {
        List<string> lst = new List<string>();
        public int summa ;
        public string orderedDringks = "";
        public Ichimliklar()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, System.EventArgs e)
         {
            Button btn= (Button)sender;

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
                        bool n = int.TryParse(b,out a);
                        if (n)
                        {
                            a++;
                            lst[i] = btn.Text +$"({a})";
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
                Ichimlik_box.Text = "";
            }
            foreach (var item in lst)
            {
                Ichimlik_box.Text += item + "  ";
            }
            

            if (btn.Text == "Pepsi")
            {
                summa += 12000;
            }
            else if (btn.Text == "Coca-Cola")
            {
                summa += 12000;
            }
            else if (btn.Text == "Fanta")
            {
                summa += 12000;
            }
            else if (btn.Text == "Dinay")
            {
                summa += 8000;
            }
            else if (btn.Text == "Soklar")
            {
                summa += 6000;
            }
            else if (btn.Text == "Choy")
            {
                summa += 3000;
            }
            else if (btn.Text == "Mevali sharbatlar")
            {
                summa += 4000;
            }
            else if (btn.Text == "Suv(gazsiz)")
            {
                summa += 2000;
            }
        }

        private void btn_asosiy_menu_Click(object sender, System.EventArgs e)
        {
            orderedDringks = Ichimlik_box.Text;
            this.Close();
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            Ichimlik_box.Text = string.Empty;
            summa = 0;
            lst.Clear();
        }
    }
}
