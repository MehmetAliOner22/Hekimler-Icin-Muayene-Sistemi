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
    public partial class HastaSil : Form
    {
        public HastaSil()
        {
            InitializeComponent();

            btnSil.Enabled = !string.IsNullOrEmpty(txtTC.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.hastaSil(Convert.ToInt64(txtTC.Text));
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtTC.Text, out value))
            {
                txtTC.Text = string.Empty;
            }

            btnSil.Enabled = !string.IsNullOrEmpty(txtTC.Text);
        }
    }
}
