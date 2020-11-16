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
        Random deck = new Random();
        int [] poker = new int [52];
        int startchack = 0;
        int p1card;
        int c1card;
        int nowdeck = 0;
        int ppoint = 0;
        int cpoint = 0;
        int handcards = 2;
        // 能要牌 要牌機制要做 
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
            switch (startchack)
            {
                case 0:
                    {
                        test.Text = "";
                        p1.Image = list[52];
                        c1.Image = list[52];
                        p1card = poker[nowdeck];
                        nowdeck += 1;                        
                        c1card = poker[nowdeck];
                        nowdeck += 1;
                        p2.Image = list[poker[nowdeck]];
                        nowdeck += 1;
                        this.Controls.Add(p2);
                        p2.BringToFront();
                        c2.Image = list[poker[nowdeck]];
                        nowdeck += 1;
                        this.Controls.Add(c2);
                        c2.BringToFront();
                        startchack = 1;
                        break;
                    }
                case 1:
                    {
                        ppoint = 0;
                        cpoint = 0;
                        nowdeck = 0;
                        handcards = 2;
                        p3.Image = null;
                        p4.Image = null;
                        p5.Image = null;
                        c3.Image = null;
                        c4.Image = null;
                        c5.Image = null;
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
                        p1card = poker[nowdeck];
                        nowdeck += 1;
                        c1card = poker[nowdeck];
                        nowdeck += 1;
                        p2.Image = list[poker[nowdeck]];
                        nowdeck += 1;
                        this.Controls.Add(p2);
                        p2.BringToFront();
                        c2.Image = list[poker[nowdeck]];
                        nowdeck += 1;
                        this.Controls.Add(c2);
                        c2.BringToFront();
                        break;
                    }
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            switch (startchack)
            {
                case 0:
                    {
                        test.Text = "請先按開始";
                        break;
                    }
                case 1:
                    {
                        switch (handcards)
                        {
                            case 2:
                                {
                                    p3.Image = list[poker[nowdeck]];
                                    this.Controls.Add(p3);
                                    p3.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    break;
                                }
                            case 3:
                                {
                                    p4.Image = list[poker[nowdeck]];
                                    this.Controls.Add(p4);
                                    p4.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    break;
                                }
                            case 4:
                                {
                                    p5.Image = list[poker[nowdeck]];
                                    this.Controls.Add(p5);
                                    p5.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            switch (startchack)
            {
                case 0:
                    {
                        test.Text = "請先按開始";
                        break;
                    }
                case 1:
                    {

                        break;
                    }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            switch (startchack)
            {
                case 0:
                    {
                        test.Text = "請先按開始";
                        break;
                    }
                case 1:
                    {

                        break;
                    }
            }
        }
    }
}
