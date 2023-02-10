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
    public partial class MBYS : Form
    {
        public MBYS()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaEkle HE = new HastaEkle();
            HE.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaGuncelle HG = new HastaGuncelle();
            HG.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaSil HS = new HastaSil();
            HS.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuayeneEkle ME = new MuayeneEkle();
            ME.Show();
        }

        private void listeleVeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneListeleVeAra MLVA = new MuayeneListeleVeAra();
            MLVA.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuayeneSil MS = new MuayeneSil();   
            MS.Show();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IlacEkle IE = new IlacEkle();
            IE.Show();
        }

        private void listeleVeAraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IlacListeleVeAra ILVA = new IlacListeleVeAra();
            ILVA.Show();
        }

        private void silToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IlacSil IS = new IlacSil(); 
            IS.Show();

        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeleVeAraToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HastaListeleVeAra HLVA = new HastaListeleVeAra();
            HLVA.Show();
        }

        private void hastaİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaIlacListeleVeAra BHKILVA = new HastaIlacListeleVeAra();
            BHKILVA.Show();
        }

        private void birIlacınHastalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacReceteHastaListeleVeAra BIREHLVA = new IlacReceteHastaListeleVeAra();
            BIREHLVA.Show();
        }

        private void listeleVeAraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReceteListeleVeAra RLVA = new ReceteListeleVeAra();
            RLVA.Show();
        }
    }
}
