using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Mountain_Project
{
    public partial class Animation : Form
    {
        int i;
        public Animation()
        {
            
            InitializeComponent();
            i = 0;
           
        }
        private void Animation_Load(object sender, EventArgs e)
        {
            panel2.Hide();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm Start = new MainForm();
            Start.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                i+=5;
                panel1.Location = new Point(i, 379);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wezzzker");
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
            System.Diagnostics.Process.Start("https://github.com/davidkapanda");
        }
    }
}
