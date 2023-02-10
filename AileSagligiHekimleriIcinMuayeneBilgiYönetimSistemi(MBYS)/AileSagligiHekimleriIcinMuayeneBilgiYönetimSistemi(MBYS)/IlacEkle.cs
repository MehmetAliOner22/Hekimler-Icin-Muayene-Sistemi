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
    public partial class IlacEkle : Form
    {
        public IlacEkle()
        {
            InitializeComponent();

            comboTip.DropDownStyle = ComboBoxStyle.DropDownList;

            btnEkle.Enabled = !string.IsNullOrEmpty(txtBarkod.Text) && !string.IsNullOrEmpty(comboTip.Text) && !string.IsNullOrEmpty(txtAd.Text);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac();
            ilac.barkodNo = Convert.ToInt64(txtBarkod.Text);
            ilac.tip = comboTip.Text;
            ilac.ad = txtAd.Text;
            ilac.Ekle(ilac);
        }

        private void IlacEkle_Load(object sender, EventArgs e)
        {

        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtBarkod.Text, out value))
            {
                txtBarkod.Text = string.Empty;
            }

            btnEkle.Enabled = !string.IsNullOrEmpty(txtBarkod.Text) && !string.IsNullOrEmpty(comboTip.Text) && !string.IsNullOrEmpty(txtAd.Text);
        }

        private void comboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtBarkod.Text) && !string.IsNullOrEmpty(comboTip.Text) && !string.IsNullOrEmpty(txtAd.Text);
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            btnEkle.Enabled = !string.IsNullOrEmpty(txtBarkod.Text) && !string.IsNullOrEmpty(comboTip.Text) && !string.IsNullOrEmpty(txtAd.Text);
        }
    }
}
