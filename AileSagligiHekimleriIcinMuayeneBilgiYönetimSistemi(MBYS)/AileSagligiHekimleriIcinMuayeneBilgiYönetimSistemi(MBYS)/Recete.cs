using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    internal class Recete
    {
        string baglanti = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=muayeneVeri;";
        public long receteNo { get; set; }
        public DateTime tarih  { get; set; }
        public long[] ilacBarkodNo { get; set;}
        public int ekle(Recete recete) 
        {
            for (int i = 0; i < 5; i++)
            {
                if(recete.ilacBarkodNo[i] == 0) 
                { 
                    continue; 
                }

                string sorgu = "SELECT * FROM ilaclar WHERE barkodno = " + recete.ilacBarkodNo[i];

                NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

                DataSet dataSet = new DataSet();

                dataAdapter1.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(recete.ilacBarkodNo[i] + " Barkod numaralı ilaç kayıtlı değil yalnızca kayıtlı ilaçlarla ekleme yapılabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }

            NpgsqlConnection bg = new NpgsqlConnection(baglanti);
            bg.Open();

            NpgsqlCommand komut = new NpgsqlCommand("insert into recete (receteno,tarih,ilac1no,ilac2no,ilac3no,ilac4no,ilac5no) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bg);

            komut.Parameters.AddWithValue("@p1", recete.receteNo);
            komut.Parameters.AddWithValue("@p2", recete.tarih);
            komut.Parameters.AddWithValue("@p3", recete.ilacBarkodNo[0]);
            komut.Parameters.AddWithValue("@p4", recete.ilacBarkodNo[1]);
            komut.Parameters.AddWithValue("@p5", recete.ilacBarkodNo[2]);
            komut.Parameters.AddWithValue("@p6", recete.ilacBarkodNo[3]);
            komut.Parameters.AddWithValue("@p7", recete.ilacBarkodNo[4]);
            komut.ExecuteNonQuery();
            bg.Close();

            return 1;
        }
        public void Listele(DataGridView dataGridView) 
        {
            string sorgu = "SELECT * FROM recete";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
        public void AraVeListele(DateTime baslangıc, DateTime bitis, DataGridView dataGridView)
        {
            string sorgu = "SELECT * FROM recete WHERE tarih >= '" + baslangıc + "' AND tarih <= '" + bitis + "'";

            NpgsqlDataAdapter dataAdapter1 = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet dataSet = new DataSet();

            dataAdapter1.Fill(dataSet);

            dataGridView.DataSource = dataSet.Tables[0];
        }
    }
}
