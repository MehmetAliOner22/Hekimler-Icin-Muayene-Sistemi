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
    public partial class HastaIlacListeleVeAra : Form
    {
        public HastaIlacListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.hastaIlaclarAraListele(Convert.ToInt64(txtAraTC.Text), dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void HastaIlacListeleVeAra_Load(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.hastaIlaclarListele(dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void txtAraTC_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtAraTC.Text, out value))
            {
                txtAraTC.Text = string.Empty;
            }

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);
        }
    }
}
