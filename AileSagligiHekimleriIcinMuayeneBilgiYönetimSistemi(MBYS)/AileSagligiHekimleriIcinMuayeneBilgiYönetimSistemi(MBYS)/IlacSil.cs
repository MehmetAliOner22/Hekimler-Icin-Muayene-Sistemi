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
    public partial class IlacSil : Form
    {
        public IlacSil()
        {
            InitializeComponent();

            btnSil.Enabled = !string.IsNullOrEmpty(txtBarkod.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac();
            ilac.Sil(Convert.ToInt64(txtBarkod.Text));
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtBarkod.Text, out value))
            {
                txtBarkod.Text = string.Empty;
            }

            btnSil.Enabled = !string.IsNullOrEmpty(txtBarkod.Text);
        }
    }
}
