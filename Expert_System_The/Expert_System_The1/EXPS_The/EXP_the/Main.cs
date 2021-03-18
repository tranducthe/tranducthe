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

namespace ExpertSystem_The
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnsukien_Click(object sender, EventArgs e)
        {
            Events_manager frm = new Events_manager();
            frm.ShowDialog();
        }

        private void btnluat_Click(object sender, EventArgs e)
        {
            Rule_manager frm = new Rule_manager();
            frm.ShowDialog();
        }

        private void btntuvan_Click(object sender, EventArgs e)
        {
            tuvan frm = new tuvan();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MessageBox.Show("Finish this program!");
            }
            catch
            {

            }
        }
    }
}
