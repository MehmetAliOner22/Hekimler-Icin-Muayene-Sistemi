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
    public partial class ReceteListeleVeAra : Form
    {
        public ReceteListeleVeAra()
        {
            InitializeComponent();

            btnAra.Enabled = !string.IsNullOrEmpty(txtBaslangic.Text) && !string.IsNullOrEmpty(txtBitis.Text);
        }

        private void ReceteListeleVeAra_Load(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Listele(dataGridView1);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.ForeColor = Color.Black;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Recete recete = new Recete();
                recete.AraVeListele(Convert.ToDateTime(txtBaslangic.Text), Convert.ToDateTime(txtBitis.Text), dataGridView1);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                dataGridView1.Font = new Font("Arial", 12);
                dataGridView1.ForeColor = Color.Black;
            }
            catch 
            {
                MessageBox.Show("Tarihleri doğru girdiğinizden emin olun","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtBaslangic_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            btnAra.Enabled = !string.IsNullOrEmpty(txtBaslangic.Text) && !string.IsNullOrEmpty(txtBitis.Text);
        }

        private void txtBitis_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            btnAra.Enabled = !string.IsNullOrEmpty(txtBaslangic.Text) && !string.IsNullOrEmpty(txtBitis.Text);
        }
    }
}
