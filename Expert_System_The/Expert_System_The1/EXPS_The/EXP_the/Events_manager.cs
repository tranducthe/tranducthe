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
    public partial class Events_manager : Form
    {
        events_xl xl = new events_xl();
        private int id;
        public Events_manager()
        {
            InitializeComponent();
        }

        private void datasukien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (id >= 0 && id < datasukien.Rows.Count)
            {
                this.txtmask.Text = datasukien.Rows[id].Cells[0].Value.ToString();
                this.txtmotask.Text = datasukien.Rows[id].Cells[1].Value.ToString();
                this.cmbLoaiSK.Text = datasukien.Rows[id].Cells[2].Value.ToString();
            }

        }

        private void quanlysukien_Load(object sender, EventArgs e)
        {
            datasukien.DataSource = xl.loadsukien();
            cmbLoaiSK.DataSource = xl.LoadLoaiSK();
            cmbLoaiSK.DisplayMember = "loaisukien";
            cmbLoaiSK.ValueMember = "loaisukien";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmask.Text != "" && txtmotask.Text != "")
                {
                Events sk = new Events();
                sk.Masukien = txtmask.Text;
                sk.Motasukien = txtmotask.Text;
                sk.LoaiSK = cmbLoaiSK.SelectedValue.ToString() ;
                xl.them(sk);
                datasukien.DataSource = xl.loadsukien();
                }
                else
                {
                    MessageBox.Show("Do not leave blank!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Events sk = new Events();
            sk.Masukien = txtmask.Text;
            sk.Motasukien = txtmotask.Text;
            sk.LoaiSK = cmbLoaiSK.SelectedValue.ToString();
            xl.sua(sk);
            datasukien.DataSource = xl.loadsukien();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txtmask.Text;
            xl.xoa(mask);
            datasukien.DataSource = xl.loadsukien();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            String mask;
            mask = txttimkiem.Text;
            datasukien.DataSource = xl.timkiem(mask);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MessageBox.Show("Finish this program");
            }
            catch
            {

            }
        }
    }
}
