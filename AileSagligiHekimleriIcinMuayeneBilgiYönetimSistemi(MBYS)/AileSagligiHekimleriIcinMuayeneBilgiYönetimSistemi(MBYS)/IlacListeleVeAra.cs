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
    public partial class IlacListeleVeAra : Form
    {
        public IlacListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraBarkod.Text);
        }

        private void IlacListeleVeAra_Load(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac();
            ilac.Listele(dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac();
            ilac.AraVeListele(Convert.ToInt64(txtAraBarkod.Text),dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void txtAraBarkod_TextChanged(object sender, EventArgs e)
        {
            long value;
            if (!long.TryParse(txtAraBarkod.Text, out value))
            {
                txtAraBarkod.Text = string.Empty;
            }

            btnAra.Enabled = !string.IsNullOrEmpty(txtAraBarkod.Text);
        }
    }
}
