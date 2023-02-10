using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AileSagligiHekimleriIcinMuayeneBilgiYönetimSistemi_MBYS_
{
    public partial class MuayeneEkle : Form
    {
        Boolean kontrol = false;
        public MuayeneEkle()
        {
            InitializeComponent();

            comboRecete.DropDownStyle = ComboBoxStyle.DropDownList;

            txtIlac1.ReadOnly = true;
            txtIlac2.ReadOnly = true;
            txtIlac3.ReadOnly = true;
            txtIlac4.ReadOnly = true;
            txtIlac5.ReadOnly = true;

            if (comboRecete.Text == "Evet")
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
            }

            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();

            Random random = new Random();
            muayene.muayeneNo = random.Next(1000000, 2000000);

            muayene.TCNo = Convert.ToInt64(txtTC.Text);
            muayene.hastaSikayet = txtHastaSikayet.Text;
            muayene.tani = txtTani.Text;
            muayene.onerilenTedavi = txtOnerilenTedavi.Text;
            muayene.tarih = DateTime.Now;

            if(comboRecete.Text == "Evet") 
            {
                Recete recete = new Recete();
                recete.receteNo = random.Next(2000000, 3000000);
                muayene.receteNo = recete.receteNo;

                recete.tarih = DateTime.Now;

                recete.ilacBarkodNo = new long[5];

                int sayac = 0;

                if (txtIlac1.Text == "")
                {
                    recete.ilacBarkodNo[0] = 0;
                    sayac++;
                }
                else
                {
                    recete.ilacBarkodNo[0] = Convert.ToInt64(txtIlac1.Text);
                }
                if (txtIlac2.Text == "")
                {
                    recete.ilacBarkodNo[1] = 0;
                    sayac++;
                }
                else
                {
                    recete.ilacBarkodNo[1] = Convert.ToInt64(txtIlac2.Text);
                }
                if (txtIlac3.Text == "")
                {
                    recete.ilacBarkodNo[2] = 0;
                    sayac++;
                }
                else
                {
                    recete.ilacBarkodNo[2] = Convert.ToInt64(txtIlac3.Text);
                }
                if (txtIlac4.Text == "")
                {
                    recete.ilacBarkodNo[3] = 0;
                    sayac++;
                }
                else
                {
                    recete.ilacBarkodNo[3] = Convert.ToInt64(txtIlac4.Text);
                }
                if (txtIlac5.Text == "")
                {
                    recete.ilacBarkodNo[4] = 0;
                    sayac++;
                }
                else
                {
                    recete.ilacBarkodNo[4] = Convert.ToInt64(txtIlac5.Text);
                }

                //boşluğu da içerik olarak sayıyor ve aynı değer olursa hata veriyordu o yüzden sayac ile kontrol sağlandı
                if (sayac < 3)
                {
                    sayac = 0;

                    //ilaç sayısını kontrol ettiriyorum eğer benzer içerige sahip 4 textbox bulursam labele uyarı mesajı yazıyorum ve işlemlerin devam etmemesi için return; komutunu kullanıyorum
                    for (var i = 0; i < 5; i++)
                    {
                        for (var j = i + 1; j < 5; j++)
                        {
                            if (recete.ilacBarkodNo[i] == recete.ilacBarkodNo[j])
                            {
                                sayac++;

                            }
                        }

                        if (sayac < 3)
                        {
                            sayac = 0;
                        }
                        else
                        {
                            labelUyarı.Text = "Aynı ilaçtan sadece 3 adet eklenebilir.";
                            return;
                        }
                    }
                }

                if (recete.ekle(recete) == 0) 
                {
                    return;
                }
            }
            muayene.ekle(muayene);
        }
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (comboRecete.Text == "Evet")
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol) ;
        }
        private void txtHastaSikayet_TextChanged(object sender, EventArgs e)
        {
            if (comboRecete.Text == "Evet")
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);
        }
        private void txtTani_TextChanged(object sender, EventArgs e)
        {
            if (comboRecete.Text == "Evet")
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);
        }
        private void txtOnerilenTedavi_TextChanged(object sender, EventArgs e)
        {
            if (comboRecete.Text == "Evet")
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);
        }

        private void comboRecete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRecete.Text == "Evet")
            {
                txtIlac1.ReadOnly = false;
            }
            if (comboRecete.Text == "Hayır")
            {
                txtIlac1.Text = "";
                txtIlac1.ReadOnly = true;
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);

        }

        private void txtIlac1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIlac1.Text))
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
                txtIlac2.ReadOnly = false;
            }
            if (string.IsNullOrEmpty(txtIlac1.Text))
            {
                kontrol = !string.IsNullOrEmpty(txtIlac1.Text);
                txtIlac2.Text = "";
                txtIlac2.ReadOnly = true;
            }
            btnEkle.Enabled = !string.IsNullOrEmpty(txtTC.Text) && !string.IsNullOrEmpty(txtTani.Text) && !string.IsNullOrEmpty(txtOnerilenTedavi.Text) && !string.IsNullOrEmpty(txtHastaSikayet.Text) && !string.IsNullOrEmpty(comboRecete.Text) && (comboRecete.Text == "Hayır" || kontrol);

        }

        private void txtIlac2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIlac2.Text))
            {
                txtIlac3.ReadOnly = false;
            }
            if (string.IsNullOrEmpty(txtIlac2.Text))
            {
                txtIlac3.Text = "";
                txtIlac3.ReadOnly = true;
            }
        }

        private void txtIlac3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIlac3.Text))
            {
                txtIlac4.ReadOnly = false;
            }
            if (string.IsNullOrEmpty(txtIlac3.Text))
            {
                txtIlac4.Text = "";
                txtIlac4.ReadOnly = true;
            }
        }

        private void txtIlac4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIlac4.Text))
            {
                txtIlac5.ReadOnly = false;
            }
            if (string.IsNullOrEmpty(txtIlac4.Text))
            {
                txtIlac5.Text = "";
                txtIlac5.ReadOnly = true;
            }
        }
    }
}
