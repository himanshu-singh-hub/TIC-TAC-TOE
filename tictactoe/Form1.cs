using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = 0+"";
            label2.Text = 0+"";
            label4.Text = "X";
            
        }
        int c = 1;
        private void printchance(object sender, EventArgs e)
        {

            Button btn = ((Button)sender);
            if (btn.Text.Length == 0)
            {
                if (c % 2 != 0)
                {
                    btn.Text = "X";
                    label4.Text = "O";
                    
                }
                else
                {
                    btn.Text = "O";
                    label4.Text = "X";
                }
                c++;
            }
            //1,2,3
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //4,5,6
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                if (button4.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //7,8,9
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                if (button7.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //1,5,9
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //3,5,7
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //1,4,7
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //2,5,8
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                if (button2.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            //3,6,9
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show(textBox1.Text + " win");
                    label1.Text = (int.Parse(label1.Text) + 1) + "";

                }
                else
                {
                    MessageBox.Show(textBox2.Text + " win");
                    label2.Text = (int.Parse(label2.Text) + 1) + "";
                }
            }
            
        }
        bool isEqual(int i, int j, int k)
        {
            if (groupBox1.Controls[i].Text == groupBox1.Controls[j].Text && groupBox1.Controls[j].Text == groupBox1.Controls[k].Text) return true;
            else return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
             //for (int i = 0; i < 9; i++) groupBox1.Controls[i].Text = i + "";
             //MessageBox.Show(Form1.ActiveForm.Controls[1].Text);
             for (int i = 0; i < 9; i++) groupBox1.Controls[i].Text = "";
             //MessageBox.Show(isEqual(0, 1, 2).ToString());
        }
        
    }
} 