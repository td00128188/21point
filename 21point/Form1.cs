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
        int c1card;
        int nowdeck = 0;
        int handcards = 2;
        int ppoint;
        int cpoint;
        int pa;
        int ca;
        int x;
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
            deckp.Image = list[52];
            test.Text = "";
        }

        private void start_Click(object sender, EventArgs e)//開始
        {
            pa = 0;
            ca = 0;
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
            test.Text = "";
            p1.Image = list[poker[nowdeck]];
            x = (poker[nowdeck] + 1) % 13;
            if(x == 0 | x >= 10)
            {
                ppoint = ppoint + 10;
            }
            else if(x == 1)
            {
                ppoint = ppoint + 11;
                pa = 1;
            }
            else
            {
                ppoint = ppoint + x;
            }
            nowdeck += 1;
            c2.Image = list[poker[nowdeck]];
            x = (poker[nowdeck] + 1) % 13;
            if (x == 0 | x >= 10)
            {
                cpoint = cpoint + 10;
            }
            else if (x == 1)
            {
                cpoint = cpoint + 11;
                ca = 1;
            }
            else
            {
                cpoint = cpoint + x;
            }
            this.Controls.Add(c2);
            c2.BringToFront();
            nowdeck += 1;
            p2.Image = list[poker[nowdeck]];
            x = (poker[nowdeck] + 1) % 13;
            if (x == 0 | x >= 10)
            {
                ppoint = ppoint + 10;
            }
            else if (x == 1)
            {              
                if(pa == 1)
                {
                    ppoint = ppoint + 1;
                }
                else
                {
                    ppoint = ppoint + 11;
                    pa = 1;
                }
            }
            else
            {
                ppoint = ppoint + x;
            }
            this.Controls.Add(p2);
            p2.BringToFront();
            nowdeck += 1;
            c1.Image = list[52];
            c1card = poker[nowdeck];
            x = (poker[nowdeck] + 1) % 13;
            if (x == 0 | x >= 10)
            {
                cpoint = cpoint + 10;
            }
            else if (x == 1)
            {
                if(ca == 1)
                {
                    cpoint = cpoint + 1;
                }
                else
                {
                    cpoint = cpoint + 11;
                    ca = 1;
                }

            }
            else
            {
                cpoint = cpoint + x;
            }
            nowdeck += 1;
            startchack = 1;
            int bj = 0;
            if (ppoint == 21)
            {
                MessageBox.Show("Black Jeck","", MessageBoxButtons.OK);
                bj = 1;
            }
            while(bj == 1)
            {
                int card5 = 0;
                int chit = 1;
                for (int i = 0; i < chit; i++)
                {
                    if (cpoint < 17 & chit == 1)
                    {
                        c3.Image = list[poker[nowdeck]];
                        this.Controls.Add(c3);
                        c3.BringToFront();
                        x = (poker[nowdeck] + 1) % 13;
                        if (x == 0 | x >= 10)
                        {
                            cpoint = cpoint + 10;
                            if (ca == 1)
                            {
                                cpoint = cpoint - 10;
                                ca = 0;
                            }
                        }
                        else if (x == 1)
                        {
                            if (ca == 0)
                            {
                                cpoint = cpoint + 11;
                                ca = 1;
                                if (cpoint > 21)
                                {
                                    cpoint = cpoint - 10;
                                    ca = 0;
                                }
                            }
                            else
                            {
                                cpoint = cpoint + 1;
                            }
                        }
                        else
                        {
                            if (ca == 0)
                            {
                                cpoint = cpoint + x;
                            }
                            else
                            {
                                cpoint = cpoint + x;
                                if (cpoint > 21)
                                {
                                    cpoint = cpoint - 10;
                                    ca = 0;
                                }
                            }
                        }
                        nowdeck += 1;
                        chit += 1;
                    }
                    else if (cpoint < 17 & chit == 2)
                    {
                        c4.Image = list[poker[nowdeck]];
                        this.Controls.Add(c4);
                        c4.BringToFront();
                        x = (poker[nowdeck] + 1) % 13;
                        if (x == 0 | x >= 10)
                        {
                            cpoint = cpoint + 10;
                            if (ca == 1)
                            {
                                cpoint = cpoint - 10;
                                ca = 0;
                            }
                        }
                        else if (x == 1)
                        {
                            if (ca == 0)
                            {
                                cpoint = cpoint + 11;
                                ca = 1;
                                if (cpoint > 21)
                                {
                                    cpoint = cpoint - 10;
                                    ca = 0;
                                }
                            }
                            else
                            {
                                cpoint = cpoint + 1;
                            }
                        }
                        else
                        {
                            if (ca == 0)
                            {
                                cpoint = cpoint + x;
                            }
                            else
                            {
                                cpoint = cpoint + x;
                                if (cpoint > 21)
                                {
                                    cpoint = cpoint - 10;
                                    ca = 0;
                                }
                            }
                        }
                        nowdeck += 1;
                        chit += 1;
                    }
                    else if (cpoint < 17 & chit == 3)
                    {
                        c5.Image = list[poker[nowdeck]];
                        this.Controls.Add(c5);
                        c5.BringToFront();
                        x = (poker[nowdeck] + 1) % 13;
                        if (x == 0 | x >= 10)
                        {
                            cpoint = cpoint + 10;
                            if (ca == 1)
                            {
                                cpoint = cpoint - 10;
                                ca = 0;
                            }
                        }
                        else if (x == 1)
                        {
                            cpoint = cpoint + 1;
                        }
                        else
                        {
                            if (ca == 0)
                            {
                                cpoint = cpoint + x;
                            }
                            else
                            {
                                cpoint = cpoint + x;
                                if (cpoint > 21)
                                {
                                    cpoint = cpoint - 10;
                                    ca = 0;
                                }
                            }
                        }
                        nowdeck += 1;
                        chit += 1;
                        if (cpoint < 21)
                        {
                            MessageBox.Show("過五關，莊家勝", "", MessageBoxButtons.OK);
                            card5 = 1;
                            startchack = 0;
                        }
                    }
                }
                c1.Image = list[poker[3]];
                while (card5 == 0 & cpoint <= 21)
                {
                    if (cpoint == ppoint)
                    {
                        MessageBox.Show("平手", "點數比較結果", MessageBoxButtons.OK);
                    }
                    else if (cpoint > ppoint)
                    {
                        MessageBox.Show("莊家大  ", "點數比較結果", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("閒家大", "點數比較結果", MessageBoxButtons.OK);
                    }
                    break;
                }
                if (cpoint > 21)
                {
                    MessageBox.Show("莊家爆牌，閒家勝", "點數比較結果", MessageBoxButtons.OK);
                }
                startchack = 0;
                break;
            }
        }

        private void bt1_Click(object sender, EventArgs e)//HIT
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
                                    x = (poker[nowdeck] + 1) % 13;
                                    if (x == 0 | x >= 10)
                                    {
                                        ppoint = ppoint + 10;
                                        if(pa == 1)
                                        {
                                            ppoint = ppoint - 10;
                                            pa = 0;
                                        }
                                    }
                                    else if (x == 1)
                                    {
                                        if(pa == 0)
                                        {
                                            ppoint = ppoint + 11;
                                            pa = 1;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                        else
                                        {
                                            ppoint = ppoint + 1;
                                        }
                                    }
                                    else
                                    {
                                        if(pa == 0)
                                        {
                                            ppoint = ppoint + x;
                                        }
                                        else
                                        {
                                            ppoint = ppoint + x;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                    }
                                    this.Controls.Add(p3);
                                    p3.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    if (ppoint > 21)
                                    {
                                        MessageBox.Show("閒家爆牌，莊家勝", "", MessageBoxButtons.OK);
                                        startchack = 0;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    p4.Image = list[poker[nowdeck]];
                                    x = (poker[nowdeck] + 1) % 13;
                                    if (x == 0 | x >= 10)
                                    {
                                        ppoint = ppoint + 10;
                                        if (pa == 1)
                                        {
                                            ppoint = ppoint - 10;
                                            pa = 0;
                                        }
                                    }
                                    else if (x == 1)
                                    {
                                        if(pa == 0)
                                        {
                                            ppoint = ppoint + 11;
                                            pa = 1;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                        else
                                        {
                                            ppoint = ppoint + 1;
                                        }
                                    }
                                    else
                                    {
                                        if(pa == 0)
                                        {
                                            ppoint = ppoint + x;
                                        }
                                        else
                                        {
                                            ppoint = ppoint + x;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                    }
                                    this.Controls.Add(p4);
                                    p4.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    if (ppoint > 21)
                                    {
                                        MessageBox.Show("閒家爆牌，莊家勝", "", MessageBoxButtons.OK);
                                        startchack = 0;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    p5.Image = list[poker[nowdeck]];
                                    x = (poker[nowdeck] + 1) % 13;
                                    if (x == 0 | x >= 10)
                                    {
                                        ppoint = ppoint + 10;
                                        if (pa == 1)
                                        {
                                            ppoint = ppoint - 10;
                                            pa = 0;
                                        }
                                    }
                                    else if (x == 1)
                                    {
                                        if (pa == 0)
                                        {
                                            ppoint = ppoint + 11;
                                            pa = 1;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                        else
                                        {
                                            ppoint = ppoint + 1;
                                        }
                                    }
                                    else
                                    {
                                        if(pa == 0)
                                        {
                                            ppoint = ppoint + x;
                                        }
                                        else
                                        {
                                            ppoint = ppoint + x;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                    }
                                    this.Controls.Add(p5);
                                    p5.BringToFront();
                                    nowdeck += 1;
                                    handcards += 1;
                                    if(ppoint > 21)
                                    {
                                        MessageBox.Show("閒家爆牌，莊家勝", "", MessageBoxButtons.OK);
                                        startchack = 0;
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    p6.Image = list[poker[nowdeck]];
                                    this.Controls.Add(p6);
                                    p6.BringToFront();
                                    x = (poker[nowdeck] + 1) % 13;
                                    if (x == 0 | x >= 10)
                                    {
                                        ppoint = ppoint + 10;
                                        if (pa == 1)
                                        {
                                            ppoint = ppoint - 10;
                                            pa = 0;
                                        }
                                    }
                                    else if (x == 1)
                                    {
                                        if (pa == 0)
                                        {
                                            ppoint = ppoint + 11;
                                            pa = 1;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                        else
                                        {
                                            ppoint = ppoint + 1;
                                        }
                                    }
                                    else
                                    {
                                        if (pa == 0)
                                        {
                                            ppoint = ppoint + x;
                                        }
                                        else
                                        {
                                            ppoint = ppoint + x;
                                            if (ppoint > 21)
                                            {
                                                ppoint = ppoint - 10;
                                                pa = 0;
                                            }
                                        }
                                    }
                                    nowdeck += 1;
                                    handcards += 1;
                                    if (ppoint > 21)
                                    {
                                        MessageBox.Show("閒家爆牌，莊家勝", "", MessageBoxButtons.OK);
                                        startchack = 0;
                                    }
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private void bt2_Click(object sender, EventArgs e)//STAND
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
                        int card5 = 0;
                        int chit = 1;
                        for (int i = 0; i < chit; i++)
                        {
                            if (cpoint < 17 & chit == 1)
                            {
                                c3.Image = list[poker[nowdeck]];
                                this.Controls.Add(c3);
                                c3.BringToFront();
                                x = (poker[nowdeck] + 1) % 13;
                                if (x == 0 | x >= 10)
                                {
                                    cpoint = cpoint + 10;
                                    if (ca == 1)
                                    {
                                        cpoint = cpoint - 10;
                                        ca = 0;
                                    }
                                }
                                else if (x == 1)
                                {
                                    if (ca == 0)
                                    {
                                        cpoint = cpoint + 11;
                                        ca = 1;
                                        if (cpoint > 21)
                                        {
                                            cpoint = cpoint - 10;
                                            ca = 0;
                                        }
                                    }
                                    else
                                    {
                                        cpoint = cpoint + 1;
                                    }
                                }
                                else
                                {
                                    if (ca == 0)
                                    {
                                        cpoint = cpoint + x;
                                    }
                                    else
                                    {
                                        cpoint = cpoint + x;
                                        if (cpoint > 21)
                                        {
                                            cpoint = cpoint - 10;
                                            ca = 0;
                                        }
                                    }
                                }
                                nowdeck += 1;
                                chit += 1;
                            }
                            else if (cpoint < 17 & chit == 2)
                            {
                                c4.Image = list[poker[nowdeck]];
                                this.Controls.Add(c4);
                                c4.BringToFront();
                                x = (poker[nowdeck] + 1) % 13;
                                if (x == 0 | x >= 10)
                                {
                                    cpoint = cpoint + 10;
                                    if (ca == 1)
                                    {
                                        cpoint = cpoint - 10;
                                        ca = 0;
                                    }
                                }
                                else if (x == 1)
                                {
                                    if (ca == 0)
                                    {
                                        cpoint = cpoint + 11;
                                        ca = 1;
                                        if (cpoint > 21)
                                        {
                                            cpoint = cpoint - 10;
                                            ca = 0;
                                        }
                                    }
                                    else
                                    {
                                        cpoint = cpoint + 1;
                                    }
                                }
                                else
                                {
                                    if (ca == 0)
                                    {
                                        cpoint = cpoint + x;
                                    }
                                    else
                                    {
                                        cpoint = cpoint + x;
                                        if (cpoint > 21)
                                        {
                                            cpoint = cpoint - 10;
                                            ca = 0;
                                        }
                                    }
                                }
                                nowdeck += 1;
                                chit += 1;
                            }
                            else if (cpoint < 17 & chit == 3)
                            {
                                c5.Image = list[poker[nowdeck]];
                                this.Controls.Add(c5);
                                c5.BringToFront();
                                x = (poker[nowdeck] + 1) % 13;
                                if (x == 0 | x >= 10)
                                {
                                    cpoint = cpoint + 10;
                                    if (ca == 1)
                                    {
                                        cpoint = cpoint - 10;
                                        ca = 0;
                                    }
                                }
                                else if (x == 1)
                                {
                                    cpoint = cpoint + 1;
                                }
                                else
                                {
                                    if (ca == 0)
                                    {
                                        cpoint = cpoint + x;
                                    }
                                    else
                                    {
                                        cpoint = cpoint + x;
                                        if (cpoint > 21)
                                        {
                                            cpoint = cpoint - 10;
                                            ca = 0;
                                        }
                                    }
                                }
                                nowdeck += 1;
                                chit += 1;
                                if (cpoint < 21)
                                {
                                    MessageBox.Show("過五關，莊家勝", "", MessageBoxButtons.OK);
                                    card5 = 1;
                                    startchack = 0;
                                }
                            }
                        }
                        c1.Image = list[poker[3]];
                        while(card5 == 0 & cpoint <= 21)
                        {
                            if (cpoint == ppoint)
                            {
                                MessageBox.Show("平手", "點數比較結果", MessageBoxButtons.OK);
                            }
                            else if (cpoint > ppoint)
                            {
                                MessageBox.Show("莊家大  ", "點數比較結果", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("閒家大", "點數比較結果", MessageBoxButtons.OK);
                            }
                            break;
                        }
                        if(cpoint > 21)
                        {
                            MessageBox.Show("莊家爆牌，閒家勝", "點數比較結果", MessageBoxButtons.OK);
                        }
                        startchack = 0;
                        break;
                    }
            }
        }
    }
}
