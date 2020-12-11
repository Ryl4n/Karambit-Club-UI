using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Csharp_autoclicker_UI
{
    public partial class Form2 : Form
    {
       
        string HWID;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.ShowIcon = false; 
        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {








            this.Hide();
            string pc = Environment.UserName;
            Form1 frm1 = new Form1();

           

                frm1.Show();
          
          




        }

        private void skeetButton1_Click(object sender, EventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            MessageBox.Show("Copied");
            Clipboard.SetText(HWID);
           

        }

        private void skeetBackground1_Click(object sender, EventArgs e)
        {

        }
    }
}
