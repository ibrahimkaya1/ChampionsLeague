using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChampionsLeaugue
{
    public partial class Finaller : Form
    {
        internal ListBox listLast16;

        public Finaller()
        {
            InitializeComponent();
        }

        private void Finaller_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < listLast16.Items.Count; i++)
            {
                listBox1.Items.Add(listLast16.Items[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eslestir();
            button1.Visible= false;
            button2.Visible= true;
        }

        private void Eslestir()
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int sayi = listBox1.Items.Count / 2;
            Random rnd = new Random();
            for (int i = 1; i <= sayi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                listBox2.Items.Add(listBox1.Items[tutulan]);
                listBox1.Items.RemoveAt(tutulan);
            }
            for (int i = 1; i <= sayi; i++)
            {
                int tutulan = rnd.Next(0, listBox1.Items.Count);
                listBox3.Items.Add(listBox1.Items[tutulan]);
                listBox1.Items.RemoveAt(tutulan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duello();
            button1.Visible = true;
            button2.Visible = false;
        }

        private void Duello()
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            int goal1;
            int goal2;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                goal1 = rnd.Next(9);
                goal2 = rnd.Next(9);
                listBox4.Items.Add(listBox2.Items[i] + "    " + goal1 + "-" + goal2 + "    " + listBox3.Items[i]);
                if (goal1 > goal2)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
                else
                {
                    listBox1.Items.Add(listBox3.Items[i]);
                }
            }
            if (listBox1.Items.Count == 1)
            {
                MessageBox.Show("ŞAMPİYONLAR LİGİ ŞAMPİYONU " + listBox1.Items[0]);
                Finaller finaller = new Finaller();
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
