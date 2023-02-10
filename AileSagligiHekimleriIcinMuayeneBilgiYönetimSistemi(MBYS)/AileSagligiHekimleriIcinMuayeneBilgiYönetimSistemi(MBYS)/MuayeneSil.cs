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
    public partial class MuayeneSil : Form
    {
        public MuayeneSil()
        {
            InitializeComponent();

            btnSil.Enabled = !string.IsNullOrEmpty(txtMN.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.MuayeneSil(Convert.ToInt64(txtMN.Text));
        }

        private void txtMN_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtMN.Text, out value))
            {
                txtMN.Text = string.Empty;
            }

            btnSil.Enabled = !string.IsNullOrEmpty(txtMN.Text);
        }
    }
}
