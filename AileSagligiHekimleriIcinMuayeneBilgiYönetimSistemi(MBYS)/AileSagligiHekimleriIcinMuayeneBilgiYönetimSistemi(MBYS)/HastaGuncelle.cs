using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    public partial class HastaGuncelle : Form
    {
        public HastaGuncelle()
        {
            InitializeComponent();

            txtAd.ReadOnly = true;
            txtSoyad.ReadOnly = true;
            txtDYeri.ReadOnly = true;
            txtMedeniDurum.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtAdres.ReadOnly = true;

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);
            btnGuncelle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtAraTC_TextChanged(object sender, EventArgs e)
        {
            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);

            long value;
            if (!long.TryParse(txtAraTC.Text, out value))
            {
                txtAraTC.Text = string.Empty;
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            Hasta hasta = new Hasta();
            if (hasta.hastaAraListele(Convert.ToInt64(txtAraTC.Text), dataGridView1) == 1)
            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                dataGridView1.Font = new Font("Arial", 12);
                dataGridView1.ForeColor = Color.Black;

                txtAraTC.ReadOnly = true;
                txtAd.ReadOnly = false;
                txtSoyad.ReadOnly = false;
                txtDYeri.ReadOnly = false;
                txtMedeniDurum.ReadOnly = false;
                txtTel.ReadOnly = false;
                txtAdres.ReadOnly = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            hasta.TCNo = Convert.ToInt64(txtAraTC.Text);
            hasta.ad = txtAd.Text;
            hasta.soyad = txtSoyad.Text;
            hasta.adres = txtAdres.Text;
            hasta.telefonNo = txtTel.Text;

            if (txtDYeri.Text == "" && txtMedeniDurum.Text != "")
            {
                hasta.dogumYeri = "";
                hasta.medeniDurum = txtMedeniDurum.Text;
            }
            else if (txtDYeri.Text != "" && txtMedeniDurum.Text == "")
            {
                hasta.dogumYeri = txtDYeri.Text;
                hasta.medeniDurum = "";
            }
            else if (txtMedeniDurum.Text == "" && txtDYeri.Text == "")
            {
                hasta.dogumYeri = "";
                hasta.medeniDurum = "";
            }
            else
            {
                hasta.dogumYeri = txtDYeri.Text;
                hasta.medeniDurum = txtMedeniDurum.Text;
            }

            hasta.hastaGuncelle(hasta);

            txtAraTC.ReadOnly = false;
            txtAd.ReadOnly = true;
            txtSoyad.ReadOnly = true;
            txtDYeri.ReadOnly = true;
            txtMedeniDurum.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtAdres.ReadOnly = true;
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void HastaGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
