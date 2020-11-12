using _21point.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21point
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        int [] poker = new int [52];
        int startchack = 0;
        int p1card;
        int pcards = 2;
        int ppoint;
        int ppass = 0;
        int c1card;
        int cpass = 0;
        int ccards = 2;
        int cpoint;
        int nowdeck = 0;
        int aa;
        int bb;
        int x;
        Random Cchose = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._1);
            list.Add(Resources._2);
            list.Add(Resources._3);
            list.Add(Resources._4);
            list.Add(Resources._5);
            list.Add(Resources._6);
            list.Add(Resources._7);
            list.Add(Resources._8);
            list.Add(Resources._9);
            list.Add(Resources._10);
            list.Add(Resources._11);
            list.Add(Resources._12);
            list.Add(Resources._13);
            list.Add(Resources._14);
            list.Add(Resources._15);
            list.Add(Resources._16);
            list.Add(Resources._17);
            list.Add(Resources._18);
            list.Add(Resources._19);
            list.Add(Resources._20);
            list.Add(Resources._21);
            list.Add(Resources._22);
            list.Add(Resources._23);
            list.Add(Resources._24);
            list.Add(Resources._25);
            list.Add(Resources._26);
            list.Add(Resources._27);
            list.Add(Resources._28);
            list.Add(Resources._29);
            list.Add(Resources._30);
            list.Add(Resources._31);
            list.Add(Resources._32);
            list.Add(Resources._33);
            list.Add(Resources._34);
            list.Add(Resources._35);
            list.Add(Resources._36);
            list.Add(Resources._37);
            list.Add(Resources._38);
            list.Add(Resources._39);
            list.Add(Resources._40);
            list.Add(Resources._41);
            list.Add(Resources._42);
            list.Add(Resources._43);
            list.Add(Resources._44);
            list.Add(Resources._45);
            list.Add(Resources._46);
            list.Add(Resources._47);
            list.Add(Resources._48);
            list.Add(Resources._49);
            list.Add(Resources._50);
            list.Add(Resources._51);
            list.Add(Resources._52);
            list.Add(Resources._00);

            Random deck = new Random();
            for (int i = 0; i < 52; i++)
            {
                poker[i] = deck.Next(0, 52);
                for (int j = 0; j < i; j++)
                {
                    while (poker[j] == poker[i])
                    {
                        j = 0;
                        poker[i] = deck.Next(0, 52);
                    }
                }
            }
            deckp.Image = list[52];
            test.Text = "";
        }

        private void start_Click(object sender, EventArgs e)
        {
            nowdeck = 0;
            startchack = 1;
            test.Text = "";
            while(startchack == 1)
            {
                Random deck = new Random();
                for (int i = 0; i < 52; i++)
                {
                    poker[i] = deck.Next(0, 52);
                    for (int j = 0; j < i; j++)
                    {
                        while (poker[j] == poker[i])
                        {
                            j = 0;
                            poker[i] = deck.Next(0, 52);
                        }
                    }
                }
                aa = poker[0] % 13;
                if (aa == 0)
                    aa = 13;
                bb = poker[1] % 13;
                if (bb == 0)
                    bb = 13;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                c3.Image = null;
                c4.Image = null;
                c5.Image = null;
                pcards = 2;
                ccards = 2;
                p1.Image = list[52];
                p1card = aa;
                C1.Image = list[52];
                c1card = bb;
                p1card = poker[nowdeck];
                p2.Image = list[poker[nowdeck]];
                this.Controls.Add(p2);
                p2.BringToFront();
                nowdeck = nowdeck + 1;
                c1card = poker[nowdeck];
                c2.Image = list[poker[nowdeck]];
                this.Controls.Add(c2);
                c2.BringToFront();
                nowdeck = nowdeck + 1;

                startchack = 2;
                break;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            while (startchack == 0)
            {
                test.Text = "請先按開始";
                break;
            }
            while (startchack == 2)
            {
                test.Text = "";
                pcards = pcards + 1;
                switch (pcards)
                {
                    case 3:
                        {
                            p3.Image = list[poker[nowdeck]];
                            this.Controls.Add(p3);
                            p3.BringToFront();
                            nowdeck = nowdeck + 1;
                            x = Cchose.Next(1, 3);
                            if(x == 1)
                            {
                                c3.Image = list[poker[nowdeck]];
                                this.Controls.Add(c3);
                                c3.BringToFront();
                                nowdeck = nowdeck + 1;
                            }
                            if (x == 2)
                            {
                                cpass = 1;
                            }
                            break;
                        }
                    case 4:
                        {
                            p4.Image = list[poker[nowdeck]];
                            this.Controls.Add(p4);
                            p4.BringToFront();
                            nowdeck = nowdeck + 1;
                            x = Cchose.Next(1, 3);
                            if (x == 1 && cpass ==0)
                            {
                                c4.Image = list[poker[nowdeck]];
                                this.Controls.Add(c4);
                                c4.BringToFront();
                                nowdeck = nowdeck + 1;
                            }
                            if (x == 2)
                            {
                                cpass = 1;
                            }
                            break;
                        }
                    case 5:
                        {
                            p5.Image = list[poker[nowdeck]];
                            this.Controls.Add(p5);
                            p5.BringToFront();
                            nowdeck = nowdeck + 1;
                            x = Cchose.Next(1, 3);
                            if (x == 1 && cpass == 0)
                            {
                                c5.Image = list[poker[nowdeck]];
                                this.Controls.Add(c5);
                                c5.BringToFront();
                                nowdeck = nowdeck + 1;
                            }
                            if (x == 2)
                            {
                                cpass = 1;
                            }
                            break;
                        }
                }
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (startchack == 0)
            {
                test.Text = "請先按開始";
                break;
            }
            while (startchack == 2)
            {
                test.Text = "";
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (startchack == 0)
            {
                test.Text = "請先按開始";
                break;
            }
            while (startchack == 2)
            {
                test.Text = "";
                MessageBox.Show($"{p1card % 13}", "你的底牌", MessageBoxButtons.OK);
                break;
            }
        }
    }
}
