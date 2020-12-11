using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Csharp_autoclicker_UI
{
    public partial class Form1 : Form
    {
        //dw bout this
        public string bl = Environment.UserName;
        public Form1()
        {

            //seting background colour.
            Console.ForegroundColor = ConsoleColor.Magenta;
            //setting console title
            Console.Title = "rylan.vip | cool kid ui base";
            

            Console.WriteLine("loading ui..");
            Thread.Sleep(200);
            Console.WriteLine("thank you for using my ui base ");


            Thread.Sleep(500);
            Console.Clear();



          
            





            InitializeComponent();
        }

        private void loading(object sender, EventArgs e)
        {

            //dont owrry bout this
            skeetGroupBox1.Visible = false;
            skeetGroupBox2.Visible = false;
            skeetGroupBox3.Visible = false;
            skeetGroupBox4.Visible = false;
            skeetGroupBox5.Visible = false;
            skeetGroupBox6.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            Console.WriteLine("Enter your username");

            


            //strings for console
            string NAME = Environment.UserName;
            string pog = Console.ReadLine();
            Thread.Sleep(700);
            //plays beep noise cause its cool i guess
            Console.Beep();
            this.Visible = true;
            Console.Clear();
          
            


            label4.Text = "Registered to " + pog;
            
         





            this.ShowIcon = false;

            //put the name of your app here
            this.Text = "karambit club ui";
                       //^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {

            //tabs
            skeetGroupBox1.Visible = true;
            skeetGroupBox2.Visible = true;
            skeetGroupBox3.Visible = true;
            skeetGroupBox4.Visible = true;
            skeetGroupBox5.Visible = false;
            skeetGroupBox6.Visible = false;
            // skeetGroupBox5.Visible = true;
            //skeetGroupBox6.Visible = false;

        }

        private void skeetSlider2_Load(object sender, EventArgs e)
        {
           
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            //settings the group box location
            skeetGroupBox5.Location = new Point(13, 69);
            //more tabs
            skeetGroupBox1.Visible = false;
            skeetGroupBox2.Visible = false;
            skeetGroupBox3.Visible = false;
            skeetGroupBox4.Visible = false;
            skeetGroupBox5.Visible = true;
            skeetGroupBox6.Visible = false;

        }

        private void skeetButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skeetGroupBox6_Enter(object sender, EventArgs e)
        {
            //more tabs
            skeetGroupBox6.Location = new Point(13, 69);
            skeetGroupBox1.Visible = false;
            skeetGroupBox2.Visible = false;
            skeetGroupBox3.Visible = false;
            skeetGroupBox4.Visible = false;
            skeetGroupBox5.Visible = false;
        }

        private void skeetButton3_Click(object sender, EventArgs e)
        {
            //more tabs
            skeetGroupBox6.Visible = true;
            skeetGroupBox6.Location = new Point(13, 69);
            skeetGroupBox1.Visible = false;
            skeetGroupBox2.Visible = false;
            skeetGroupBox3.Visible = false;
            skeetGroupBox4.Visible = false;
            skeetGroupBox5.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void skeetBackground1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void skeetGroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void skeetButton10_Click(object sender, EventArgs e)
        {
            

            Console.WriteLine("Enter text");



            

            //strings for console
            string NAME = Environment.UserName;

            //other thing
            string pog = Console.ReadLine();
           
            //plays beep noise cause its cool i guess
            Console.Beep();
            
            Console.Clear();




            label4.Text = pog;


        }

        private void skeetSlider8_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dsad");
        }

        private void skeetSlider6_Load(object sender, EventArgs e)
        {

        }

        private void skeetGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void skeetGroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void skeetSlider7_Load(object sender, EventArgs e)
        {

        }
    }
}
