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
    public partial class IlacReceteHastaListeleVeAra : Form
    {
        public IlacReceteHastaListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);
        }

        private void IlacReceteHastaListeleVeAra_Load(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.IlacHastaListele(dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.IlacHastaAraListele(Convert.ToInt64(txtAraTC.Text), dataGridView1);

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
