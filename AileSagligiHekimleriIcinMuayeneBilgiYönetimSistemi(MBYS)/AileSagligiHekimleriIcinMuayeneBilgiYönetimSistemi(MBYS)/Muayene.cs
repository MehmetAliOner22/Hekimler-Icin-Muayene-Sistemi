using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    internal class Muayene
    {
        string baglanti = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=muayeneVeri;";
        public long muayeneNo { get; set; }
        public long TCNo { get; set; }
        public DateTime tarih { get; set; }
        public string hastaSikayet { get; set; }
        public string tani { get; set; }
        public string onerilenTedavi { get; set; }
        public long receteNo { get; set; }
        public void ekle(Muayene muayene)
        {
            string sorgu = "SELECT * FROM hasta WHERE tcno = " + muayene.TCNo;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(TCNo + " TC numaralı hasta listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sorgu2 = "SELECT * FROM muayene WHERE tcno = " + muayene.TCNo + " AND tarih = '" + muayene.tarih + "'";

            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter(sorgu2, baglanti);

            dataSet.Clear();

            dataAdapter2.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show(muayene.TCNo + " TC numaralı hasta " + muayene.tarih + " tarihinde zaten muayene olmuştur", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("insert into muayene (muayeneno,tcno,tarih,hastasikayeti,tani,onerilentedavi,receteno) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bg);

            komut.Parameters.AddWithValue("@p1", muayene.muayeneNo);
            komut.Parameters.AddWithValue("@p2", muayene.TCNo);
            komut.Parameters.AddWithValue("@p3", muayene.tarih);
            komut.Parameters.AddWithValue("@p4", muayene.hastaSikayet);
            komut.Parameters.AddWithValue("@p5", muayene.tani);
            komut.Parameters.AddWithValue("@p6", muayene.onerilenTedavi);
            komut.Parameters.AddWithValue("@p7", muayene.receteNo);
            komut.ExecuteNonQuery();
            bg.Close();

            MessageBox.Show(muayene.muayeneNo + " numaralı muayene listeden eklendi");

        }
        public void listele(DataGridView dataGridView)
        {
            string sorgu = "SELECT * FROM muayene";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void AraVeListele(long muayeneNo, DataGridView dataGridView)
        {
            string sorgu = "SELECT * FROM muayene WHERE muayeneno = " + muayeneNo;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void MuayeneSil(long muayeneNo)
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("Delete from muayene where muayeneno=@p1", bg);

            komut.Parameters.AddWithValue("@p1", muayeneNo);
            int rowsAffected = komut.ExecuteNonQuery();

            bg.Close();

            if (rowsAffected == 0)
            {
                MessageBox.Show(muayeneNo + " numaralı muayeneli listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(muayeneNo + " numaralı muayene listeden silindi");
            }
        }
    }
}
