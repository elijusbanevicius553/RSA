using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Data.SQLite;

namespace RSA
{
    public partial class Form1 : Form
    {
        public int p, q;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            p = Convert.ToInt32(textBox_p.Text);
            q = Convert.ToInt32(textBox_q.Text);

            //Patikrinam ar p ir q yra pirminiai skaičiai.
            if (IsPrime(p) == true && IsPrime(q) == true)
            {

                //Jei pirminiai vykdom koda.
                //Test
                MessageBox.Show("TAIP");

            }
            else
                MessageBox.Show("Vienas arba abu skaiciai nera pirminiai");

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
