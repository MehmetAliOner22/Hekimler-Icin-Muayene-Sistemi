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
    public partial class HastaListeleVeAra : Form
    {
        public HastaListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraTC.Text);
        }

        private void HastaListeleVeAra_Load(object sender, EventArgs e)
        {
            

            Hasta hasta = new Hasta();
            hasta.hastaListele(dataGridView1);

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
            hasta.hastaAraListele(Convert.ToInt64(txtAraTC.Text),dataGridView1);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
