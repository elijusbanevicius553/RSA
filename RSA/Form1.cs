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
        public BigInteger n, fi, e, d;

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
                Keys();
            }
            else
                MessageBox.Show("Vienas arba abu skaiciai nera pirminiai");

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = Encrypt(textBox_fresh.Text);
            textBox_test.Text = Decrypt(textBox_result.Text);
        }

        public string Encrypt(string msg)
        {
            n = Convert.ToInt32(textBox_p.Text) * Convert.ToInt32(textBox_q.Text);
            e = Convert.ToInt32(textBox_e.Text);
            string str = "";
            foreach (char c in msg)
            {
                str += (char)BigInteger.ModPow((int)c, e, n);
            }
            return str;
        }

        public string Decrypt(string msg)
        {
            n = Convert.ToInt32(textBox_p.Text) * Convert.ToInt32(textBox_q.Text);
            d = Convert.ToInt32(textBox_d.Text);
            string rez = "";
            foreach (char c in msg)
            {
                rez += (char)BigInteger.ModPow((int)c, d, n);
            }
            return rez;
        }


        public void Keys()
        {
            Random r = new Random();
            List<BigInteger> Possible_e = new List<BigInteger>();

            n = p * q;
            fi = (p - 1) * (q - 1);

            int amount = 0;

            for (e = 2; e < fi; e++)
            {
                if (BigInteger.GreatestCommonDivisor(fi, e) == 1)
                {
                    amount++;
                    Possible_e.Add(e);
                }
                if (amount == 10)
                {
                    break;
                }
            }

            e = Possible_e[r.Next(0, Possible_e.Count)];

            amount = 0;

            List<BigInteger> Possible_d = new List<BigInteger>();

            for (d = p; d < fi; d++)
            {
                if (e * d % fi == 1)
                {
                    Possible_d.Add(d);

                    if (amount == 10)
                    {
                        break;
                    }
                }
            }

            d = Possible_d[r.Next(0, Possible_d.Count)];

            textBox_e.Text = Convert.ToString(e);
            textBox_d.Text = Convert.ToString(d);

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
