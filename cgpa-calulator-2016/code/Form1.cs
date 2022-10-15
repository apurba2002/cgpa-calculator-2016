using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgpa_calulator_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                // array declearation


                int[] tc = new int[10];
                int[] tf = new int[10];
                int[] pc = new int[10];
                int[] pf = new int[10];
                int[] ch = new int[10];
                int[] tm = new int[10];
                double[] gp = new double[10];
                double[] cgp = new double[10];
                int[] mark = new int[10];
                string grade;


                // subject 1

                tc[1] = Convert.ToInt32(textBox1.Text);
                tf[1] = Convert.ToInt32(textBox2.Text);
                pc[1] = Convert.ToInt32(textBox3.Text);
                pf[1] = Convert.ToInt32(textBox4.Text);
                ch[1] = Convert.ToInt32(textBox5.Text);
                tm[1] = Convert.ToInt32(textBox33.Text);

                // subject2

                tc[2] = Convert.ToInt32(textBox10.Text);
                tf[2] = Convert.ToInt32(textBox9.Text);
                pc[2] = Convert.ToInt32(textBox8.Text);
                pf[2] = Convert.ToInt32(textBox7.Text);
                ch[2] = Convert.ToInt32(textBox6.Text);
                tm[2] = Convert.ToInt32(textBox34.Text);




                // subject 3

                tc[3] = Convert.ToInt32(textBox15.Text);
                tf[3] = Convert.ToInt32(textBox14.Text);
                pc[3] = Convert.ToInt32(textBox13.Text);
                pf[3] = Convert.ToInt32(textBox12.Text);
                ch[3] = Convert.ToInt32(textBox11.Text);
                tm[3] = Convert.ToInt32(textBox35.Text);



                // subject 4

                tc[4] = Convert.ToInt32(textBox30.Text);
                tf[4] = Convert.ToInt32(textBox29.Text);
                pc[4] = Convert.ToInt32(textBox28.Text);
                pf[4] = Convert.ToInt32(textBox27.Text);
                ch[4] = Convert.ToInt32(textBox26.Text);
                tm[4] = Convert.ToInt32(textBox36.Text);

                //subject 5

                tc[5] = Convert.ToInt32(textBox25.Text);
                tf[5] = Convert.ToInt32(textBox24.Text);
                pc[5] = Convert.ToInt32(textBox23.Text);
                pf[5] = Convert.ToInt32(textBox22.Text);
                ch[5] = Convert.ToInt32(textBox21.Text);
                tm[5] = Convert.ToInt32(textBox37.Text);

                // subject 6

                tc[6] = Convert.ToInt32(textBox20.Text);
                tf[6] = Convert.ToInt32(textBox19.Text);
                pc[6] = Convert.ToInt32(textBox18.Text);
                pf[6] = Convert.ToInt32(textBox17.Text);
                ch[6] = Convert.ToInt32(textBox16.Text);
                tm[6] = Convert.ToInt32(textBox38.Text);


                for (int i = 1; i <= 6; i++)
                {
                    mark[i] = ((tc[i] + tf[i] + pc[i] + pf[i]) * 100) / tm[i];


                    if (mark[i] <= 100.00 && mark[i] >= 80.00)
                    {
                        gp[i] = 4.00;
                    }
                    else if (mark[i] < 80 && mark[i] >= 75)
                    {
                        gp[i] = 3.75;
                    }
                    else if (mark[i] < 75 && mark[i] >= 70)
                    {
                        gp[i] = 3.50;
                    }
                    else if (mark[i] < 70 && mark[i] >= 65)
                    {
                        gp[i] = 3.25;
                    }
                    else if (mark[i] < 65 && mark[i] >= 60)
                    {
                        gp[i] = 3.00;
                    }
                    else if (mark[i] < 60 && mark[i] >= 55)
                    {
                        gp[i] = 2.75;
                    }
                    else if (mark[i] < 55 && mark[i] >= 50)
                    {
                        gp[i] = 3.50;
                    }
                    else if (mark[i] < 50 && mark[i] >= 45)
                    {
                        gp[i] = 2.25;
                    }
                    else if (mark[i] < 45 && mark[i] >= 40)
                    {
                        gp[i] = 2.0;
                    }
                    else
                    {
                        gp[i] = 0.00;
                    }
                    cgp[i] = gp[i] * ch[i];
                }


                double totalcgp = 0;
                int totalcredit = 0;

                for (int i = 1; i <= 6; i++)
                {

                    totalcgp = cgp[i] + totalcgp;
                    totalcredit = ch[i] + totalcredit;


                }
                double gpa = totalcgp / totalcredit;
                textBox31.Text = gpa.ToString();

                // grade 

               if (gpa >= 5)
                {
                    grade = "A+";
                }
                else if (gpa >= 4 && gpa < 5)
                {
                    grade = "A";
                }

                else if (gpa >=3.5 && gpa <4 )
                {
                    grade = "A-";
                }
                else if (gpa >= 3 && gpa < 3.5)
                {
                    grade = "B";
                }
                else if (gpa >= 2 && gpa < 3)
                {
                    grade = "C";
                }
                else if (gpa >= 1 && gpa < 2)
                {
                    grade = "D";
                }
               else
                {
                    grade = "F";
                }
                textBox32.Text = grade;

            }
            catch
            {

                label46.Text = ("Please fill all field");

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            label46.Text = "";


        }
    }
}
