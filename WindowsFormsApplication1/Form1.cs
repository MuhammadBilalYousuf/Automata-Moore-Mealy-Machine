using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        int CurrentLocX, CurrentLocY;
        int xLocation = 0;
        int yLocation = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen myPen1;
            myPen1 = new System.Drawing.Pen(System.Drawing.Color.Black);

            e.Graphics.DrawLine(myPen1, 50, 250, 360, 250);

            Rectangle rect1 = new Rectangle(340, 230, 50, 50);
            e.Graphics.DrawArc(myPen1, rect1, 140, -280);

            e.Graphics.DrawArc(myPen1, 100, 230, 250, 100, 0, 180);
            Rectangle rect2 = new Rectangle(55, 230, 50, 50);
            e.Graphics.DrawArc(myPen1, rect2, 140, -280);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 9);
           // if (pictureBox1.Location.Y + pictureBox1.Height > this.Height)
            {
                timer1.Stop();
               // timer3.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
//            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 3);

  //          if (pictureBox1.Location.Y < 30)
            {
             
                timer2.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///------------------ORIGINAL WORK----------
            string input = textBox1.Text;
            int length = input.Length;

            if (textBox1.Text =="")
            {
                pictureBox7.ImageLocation =  @"img\cross.png";
                label6.Text = "Word Rejected ";
            }
            else
            {
                char temp = input[0];
                foreach (char c in input)
                {
                    if (c == 'a' || c == 'b')
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Not belogs to this language");
                        // Console.WriteLine("Not belogs to this language");
                        break;
                    }

                }

                if (temp == input[0] || input[length - 1] == input[length - 2])
                {

                    pictureBox7.ImageLocation = @"img\tick.png";
                    label6.Text = "Word Accepted ";
                    //MessageBox.Show("Word Accepted");
                    // Console.WriteLine("Word Accepted");
                }
                else
                {
                    pictureBox7.ImageLocation = @"img\cross.png";
                    label6.Text = "Word Rejected ";
                    // MessageBox.Show("Word Rejected");
                    //   Console.WriteLine("Word Rejected");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int alen = 0, blen = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Word Rejected Invalid Word");
               // this.label14.Text = "lambda";
            }
            else
            {
                bool aflag = true;
                bool flag = true;
                string getText = textBox1.Text;
                button3.Enabled = false;
                string k = textBox1.Text;
                //lenth work
                int lengt = k.Length;
                char[] a = k.ToCharArray();
                int i = 0;
                int Radius = 30;
                bool check = true;
                foreach (char c in getText)
                {
                    if (c == 'a' || c == 'b')
                    {
                        if (c == 'a')
                        {
                            alen = alen + 1;
                        }
                        else
                        {
                            blen = blen+1;
                        }

                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    foreach (char c in getText)
                        if (c == 'a')
                        {
                            label6.Text = "q0,1";
                            if (aflag == true)
                            {
                                if (a[i] == 'b' && a[i + 1] == 'a')
                                {

                                    label14.Text = "a".ToString();
                                    label14.Refresh();
                                    for (int j = 0; j < 270; j += 1)
                                    {

                                        this.label14.Location = new System.Drawing.Point(label14.Location.X - 1, label14.Location.Y);
                                        Thread.Sleep(10);
                                    }
                                    aflag = false;
                                }
                                if (a[i] == 'a')
                                {
                                    CurrentLocX = label14.Location.X;
                                    CurrentLocY = label14.Location.Y;
                                    label14.Text = "a".ToString();

                                    this.label14.Refresh();


                                    string input = textBox1.Text;
                                    int length = input.Length;
                                    for (int j = 0; j < 1; j++)
                                    {
                                        label14.Text = "a".ToString();
                                        this.label14.Refresh();
                                        for (int z = 73; z < 433; z++)
                                        {

                                            this.label14.Location = new System.Drawing.Point(pictureBox6.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox6.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));
                                            //
                                            Thread.Sleep(10);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                CurrentLocX = label14.Location.X;
                                CurrentLocY = label14.Location.Y;
                                label14.Text = "a".ToString();

                                this.label14.Refresh();
                                

                                string input = textBox1.Text;
                                int length = input.Length;
                                for (int j = 0; j < 1; j++)
                                {
                                    label14.Text = "a".ToString();
                                    this.label14.Refresh();
                                    for (int z = 73; z < 433; z++)
                                    {

                                        this.label14.Location = new System.Drawing.Point(pictureBox6.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox6.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));
                                        //
                                        Thread.Sleep(10);
                                    }
                                }
                                aflag = true;
                            }
                               
                            

                                                    }


                        else if (c == 'b')
                        {
                            label6.Text = "q1,0";
                            if (flag == true)
                            {


                                CurrentLocX = label14.Location.X;
                                CurrentLocY = label14.Location.Y;
                                this.label14.Text = "b".ToString();
                                this.label14.Refresh();

                                for (int j = 0; j < 270; j += 1)
                                {

                                    this.label14.Location = new System.Drawing.Point(label14.Location.X + 1, label14.Location.Y);
                                    Thread.Sleep(10);
                                }




                                flag = false;
                            }
                            else
                            {
                                string input = textBox1.Text;
                                int length = input.Length - 1;
                                for (int j = 0; j < 1; j++)
                                {
                                    label14.Text = "b".ToString();
                                    this.label14.Refresh();
                                    for (int z = 160; z < 520; z++)
                                    {

                                        this.label14.Location = new System.Drawing.Point(pictureBox5.Location.X + 10 + (int)(Radius * (Math.Cos(z * Math.PI / 180))), pictureBox5.Location.Y + 8 + (int)(Radius * (Math.Sin(z * Math.PI / 180))));

                                        Thread.Sleep(10);
                                    }
                                }
                                flag = true;
                            }


                        }
                    
                        else
                        {
                            MessageBox.Show("Not Belong to given Language");
                        }
                }
                else
                {
                    MessageBox.Show("Not Belong to given Language");
                }


            }
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = true;
            string getText = textBox1.Text;
            foreach (char c in getText)
            {
                if (c == 'a' || c == 'b')
                {
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                textBox1.Clear();
                this.label14.Text = "temp";
                this.label14.Refresh();
              
                this.label14.Location = new System.Drawing.Point(CurrentLocX, CurrentLocY);
                button3.Enabled = true;

            }
            else
            {
                textBox1.Clear();
                this.label14.Text = "temp";
                this.label14.Refresh();
                button3.Enabled = true;
            }

        }
     
    }
}

