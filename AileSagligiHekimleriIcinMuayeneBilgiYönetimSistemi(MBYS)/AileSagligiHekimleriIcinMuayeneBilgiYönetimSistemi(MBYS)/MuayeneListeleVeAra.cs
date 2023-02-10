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
    public partial class MuayeneListeleVeAra : Form
    {
        public MuayeneListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraMN.Text);
        }

        private void MuayeneListeleVeAra_Load(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.listele(dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.AraVeListele(Convert.ToInt64(txtAraMN.Text), dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void txtAraMN_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtAraMN.Text, out value))
            {
                txtAraMN.Text = string.Empty;
            }

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraMN.Text);
        }
    }
}
