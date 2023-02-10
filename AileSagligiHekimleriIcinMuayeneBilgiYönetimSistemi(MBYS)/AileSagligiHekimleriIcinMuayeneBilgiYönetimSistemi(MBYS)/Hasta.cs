using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    internal class Hasta
    {
        string baglanti = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=muayeneVeri;";
        public long TCNo { get; set; }
        public string ad { get; set;}
        public string soyad { get; set;}
        public DateTime dogumTarihi { get; set;}
        public string dogumYeri { get; set; }
        public string adres { get; set; }
        public string medeniDurum { get; set; }
        public string telefonNo { get; set; }
        public void hastaEkle(Hasta hasta) 
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO hasta (tcno,ad,soyad,dogumyeri,dogumtarihi,medenidurum,adres,telefon) SELECT @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8 WHERE NOT EXISTS (SELECT 1 FROM hasta WHERE tcno = @p1)", bg);

            komut.Parameters.AddWithValue("@p1", hasta.TCNo);
            komut.Parameters.AddWithValue("@p2", hasta.ad);
            komut.Parameters.AddWithValue("@p3", hasta.soyad);
            komut.Parameters.AddWithValue("@p4", hasta.dogumYeri);
            komut.Parameters.AddWithValue("@p5", hasta.dogumTarihi);
            komut.Parameters.AddWithValue("@p6", hasta.medeniDurum);
            komut.Parameters.AddWithValue("@p7", hasta.adres);
            komut.Parameters.AddWithValue("@p8", hasta.telefonNo);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(hasta.ad + " " + hasta.soyad + " isimli hasta listeye eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata: Aynı TC numarasına sahip bir hasta zaten var!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bg.Close();
        }
        public void hastaListele(DataGridView dataGridView) 
        {
            string sorgu = "SELECT * FROM hasta";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public int hastaAraListele(long TCNo, DataGridView dataGridView) 
        {
            string sorgu = "SELECT * FROM hasta WHERE tcno = " + TCNo;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(TCNo + " TC numaralı hasta listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else
            {
                dataGridView.DataSource = dataSet.Tables[0];
                return 1;
            }
        }
        public void hastaIlaclarListele(DataGridView dataGridView)
        {
            string sorgu = "SELECT DISTINCT muayene.tcno, recete.tarih, ilaclar.barkodno, ilaclar.ad, ilaclar.tip" +
                           "\r\nFROM muayene" +
                           "\r\nINNER JOIN recete ON recete.receteno = muayene.receteno" +
                           "\r\nINNER JOIN ilaclar ON ilaclar.barkodno IN (recete.ilac1no, recete.ilac2no, recete.ilac3no, recete.ilac4no, recete.ilac5no)";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void hastaIlaclarAraListele(long TCNo, DataGridView dataGridView)
        {
            string sorgu = "SELECT DISTINCT muayene.tcno, recete.tarih, ilaclar.barkodno, ilaclar.ad, ilaclar.tip" +
                           "\r\nFROM muayene" +
                           "\r\nINNER JOIN recete ON recete.receteno = muayene.receteno" +
                           "\r\nINNER JOIN ilaclar ON ilaclar.barkodno IN (recete.ilac1no, recete.ilac2no, recete.ilac3no, recete.ilac4no, recete.ilac5no)" +
                          "where muayene.tcno = " + TCNo;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(TCNo + " TC numaralı hasta listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        public void IlacHastaListele(DataGridView dataGridView)
        {
            string sorgu = "SELECT DISTINCT ilaclar.barkodno, recete.tarih, hasta.tcno, hasta.ad,hasta.soyad,hasta.dogumyeri,hasta.dogumtarihi,hasta.medenidurum,hasta.adres,hasta.telefon" +
                           "\r\nFROM muayene" +
                           "\r\nINNER JOIN hasta ON hasta.tcno = muayene.tcno" +
                           "\r\nINNER JOIN recete ON recete.receteno = muayene.receteno" +
                           "\r\nINNER JOIN ilaclar ON ilaclar.barkodno IN (recete.ilac1no, recete.ilac2no, recete.ilac3no, recete.ilac4no, recete.ilac5no)";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void IlacHastaAraListele(long barkodno, DataGridView dataGridView)
        {
            string sorgu = "SELECT DISTINCT ilaclar.barkodno, recete.tarih, hasta.tcno, hasta.ad,hasta.soyad,hasta.dogumyeri,hasta.dogumtarihi,hasta.medenidurum,hasta.adres,hasta.telefon" +
                           "\r\nFROM muayene" +
                           "\r\nINNER JOIN hasta ON hasta.tcno = muayene.tcno" +
                           "\r\nINNER JOIN recete ON recete.receteno = muayene.receteno" +
                           "\r\nINNER JOIN ilaclar ON ilaclar.barkodno IN (recete.ilac1no, recete.ilac2no, recete.ilac3no, recete.ilac4no, recete.ilac5no)" +
                           "where ilaclar.barkodno = " + barkodno;

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataAdapter1.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(TCNo + " TC numaralı hasta listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        public void hastaGuncelle(Hasta hasta) 
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("update hasta set ad = @p1, soyad = @p2, dogumyeri = @p3, medenidurum = @p4, adres = @p5, telefon = @p6 where tcno = @p7 ", bg);
            komut.Parameters.AddWithValue("@p1", hasta.ad);
            komut.Parameters.AddWithValue("@p2", hasta.soyad);
            komut.Parameters.AddWithValue("@p3", hasta.dogumYeri);
            komut.Parameters.AddWithValue("@p4", hasta.medeniDurum);
            komut.Parameters.AddWithValue("@p5", hasta.adres);
            komut.Parameters.AddWithValue("@p6", hasta.telefonNo);
            komut.Parameters.AddWithValue("@p7", hasta.TCNo);
            komut.ExecuteNonQuery();
            bg.Close();

            MessageBox.Show(hasta.ad + " " + hasta.soyad + " isimli hasta bilgileri güncelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void hastaSil(long TCNo) 
        {
            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("Delete from hasta where tcno=@p1", bg);

            komut.Parameters.AddWithValue("@p1", TCNo);
            int rowsAffected = komut.ExecuteNonQuery();

            bg.Close();

            if (rowsAffected == 0)
            {
                MessageBox.Show(TCNo + " TC numaralı hasta listede yok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(TCNo + " TC Numaralı hasta listeden silindi");
            }
        }
    }
}
