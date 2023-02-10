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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();

            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            hasta.TCNo = Convert.ToInt64(txtTC.Text);
            hasta.ad = txtAd.Text;
            hasta.soyad = txtSoyad.Text;
            try
            {
                hasta.dogumTarihi = Convert.ToDateTime(txtDTarihi.Text);
            }
            catch
            {
                MessageBox.Show("Tarihi doğru girdiğinizden emin olun.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hasta.adres = txtAdres.Text;
            hasta.telefonNo = txtTel.Text;

            if(txtDYeri.Text == "" && txtMedeniDurum.Text != "") 
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

            hasta.hastaEkle(hasta);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtTC.Text, out value))
            {
                txtTC.Text = string.Empty;
            }

            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtDTarihi_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtDogumTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtDTarihi.Text) && !string.IsNullOrEmpty(txtAdres.Text) && !string.IsNullOrEmpty(txtTel.Text);
        }

        private void txtMedeniDurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
