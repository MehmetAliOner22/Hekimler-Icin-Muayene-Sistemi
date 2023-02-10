using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    internal class Ilac
    {
        string baglanti = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=muayeneVeri;";
        public long barkodNo { get; set; }
        public string ad { get; set; }
        public string tip { get; set;}
        public void Ekle(Ilac ilac) 
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("insert into ilaclar (barkodno,tip,ad) Select @p1,@p2,@p3 WHERE NOT EXISTS (SELECT 1 FROM ilaclar WHERE barkodno = @p1)", bg);

            komut.Parameters.AddWithValue("@p1", ilac.barkodNo);
            komut.Parameters.AddWithValue("@p2", ilac.tip);
            komut.Parameters.AddWithValue("@p3", ilac.ad);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(ilac.ad + " isimli ilac listeye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata: Aynı barkod numarasına sahip bir ilac zaten var!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bg.Close();
        }
        public void Listele(DataGridView dataGridView) 
        {
            string sorgu = "SELECT * FROM ilaclar";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void AraVeListele(long barkodNo, DataGridView dataGridView) 
        {
            string sorgu = "SELECT * FROM ilaclar WHERE barkodno = " + barkodNo;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(barkodNo + " Barkod numaralı ilac listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        public void Sil(long barkodNo) 
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("Delete from ilaclar where barkodno = @p1", bg);

            komut.Parameters.AddWithValue("@p1", barkodNo);
            int rowsAffected = komut.ExecuteNonQuery();

            bg.Close();

            if (rowsAffected == 0)
            {
                MessageBox.Show(barkodNo+ " Barkod numaralı ilac listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(barkodNo + " Barkod numaralı ilac  listeden silindi");
            }
        }
    }
}
