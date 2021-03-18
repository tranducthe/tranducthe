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
    public partial class tuvan : Form
    {
        private List<string> listMaNganh = new List<string>();
        private List<string> listTenNganh = new List<string>();
        private Connectionss kn = new Connectionss();
        private bool run = false;
        public tuvan()
        {
            InitializeComponent();
        }

        private void tuvan_Load(object sender, EventArgs e)
        {
            //load list career (load danh sach nganh)
            string qr = "select masukien,motasukien from tblsukien where loaisukien='Карьера'";
            DataTable tbTruong = kn.getTable(qr);
            for (int i = 0; i < tbTruong.Rows.Count; i++)
            {
                listMaNganh.Add(tbTruong.Rows[i][0].ToString());
                listTenNganh.Add(tbTruong.Rows[i][1].ToString());
            }

            //load academic power (load danh sach hoc luc)
            qr = "select masukien,motasukien from tblsukien where loaisukien='Возможность_обучения'";
            DataTable tbKN = kn.getTable(qr);
            cbhocluc.DataSource = tbKN;
            cbhocluc.DisplayMember = "motasukien";
            cbhocluc.ValueMember = "masukien";

            //load Block execution (Load len khoi thi)
            qr = "select masukien,motasukien from tblsukien where loaisukien='Блок_экзамена'";
            DataTable tbKhoi = kn.getTable(qr);
            cbkhoi.DataSource = tbKhoi;
            cbkhoi.DisplayMember = "motasukien";
            cbkhoi.ValueMember = "masukien";

            //load Industry group (load len nhom nganh nghe)
            qr = "select masukien,motasukien from tblsukien where loaisukien='Отраслевая_группа'";
            DataTable tbNhom = kn.getTable(qr);
            cbnhomnganh.DataSource = tbNhom;
            cbnhomnganh.DisplayMember = "motasukien";
            cbnhomnganh.ValueMember = "masukien";

            //load Interests (Load len so thich)
            qr = "select masukien,motasukien from tblsukien where loaisukien='Интересы'";
            DataTable tbST = kn.getTable(qr);
            cbsothic.DataSource = tbST;
            cbsothic.DisplayMember = "motasukien";
            cbsothic.ValueMember = "masukien";

        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            suydientien sd = new suydientien();
            sd.DocLuatTuFfile();
            run = true;
            //
            cbhocluc.Enabled = false;
            cbkhoi.Enabled = false;
            cbnhomnganh.Enabled = false;
            cbsothic.Enabled = false;
            btnTuVan.Enabled = false;

            List<string> gt = new List<string>();
            ricKQ.Text = "";
            if (cbhocluc.SelectedValue.ToString() != "")
            {
                gt.Add(cbhocluc.SelectedValue.ToString());
            }
            if (cbkhoi.SelectedValue.ToString() != "")
            {
                gt.Add(cbkhoi.SelectedValue.ToString());
            }
            if (cbnhomnganh.SelectedValue.ToString() != "")
            {
                gt.Add(cbnhomnganh.SelectedValue.ToString());
            }
            if (cbsothic.SelectedValue.ToString() != "")
            {
                gt.Add(cbsothic.SelectedValue.ToString());
            }
            int d = 0;
            progressBar.Maximum = listMaNganh.Count - 1;
            progressBar.Minimum = 0;
            if (gt.Count > 0)
            {
                int dem = 0;
                foreach (string s in listMaNganh)
                {
                    if (!run)
                    {
                        btnReset.Enabled = false;
                        break;
                    }
                    progressBar.Value = dem;
                    List<string> kl = new List<string>();
                    kl.Add(s);

                    if (sd.SuyDien(gt, kl) == true)
                    {
                        ricKQ.Text += listTenNganh.ElementAt(dem) + "\n";
                        d++;
                    }
                    dem++;
                    SendKeys.Flush();
                }
                if (d == 0 && run != false)
                {
                    ricKQ.Text = "Нет отрасли, отвечающей требованиям отбора.!!!\nПожалуйста, выберите еще раз!!\nМы обновим информацию в ближайшее время!";
                }
            }
            else
            {
                MessageBox.Show("Вам нужно выбрать полную информацию!");
            }
            cbhocluc.Enabled = true;
            cbkhoi.Enabled = true;
            cbnhomnganh.Enabled = true;
            cbsothic.Enabled = true;
            btnTuVan.Enabled = true;
        }
        private int FinIndex(string input, List<string> s)
        {
            int i = 0;
            foreach (string a in s)
            {
                if (input == a)
                {
                    return i;
                }
                i++;
            }
            return 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ricKQ.Text = "";
            cbhocluc.Text = "";
            cbkhoi.Text = "";
            cbnhomnganh.Text = "";
            cbsothic.Text = "";
            run = false;
            progressBar.Value = progressBar.Maximum;
        }

        private void cbkhoi_SelectedIndexChanged(object sender, EventArgs e)
        {

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
