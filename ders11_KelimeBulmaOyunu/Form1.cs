using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace KelimeBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int second = 0;

        SoundPlayer butonses;
        SoundPlayer alkisses;
        SoundPlayer aaases;

        string adsoyadliste;


        string kelime, harf,soru;
        int uzunluk;
        int bilinenharfler;
        
        int kalansure = 240;
        int puan = 0;
        int soruPuan = 0;
        int soruSayac = 0;
        string[] harfler;
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=kelimebulma;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            tarihlbl.Text = DateTime.Now.ToLongTimeString();
            tarih2lbl.Text = DateTime.Now.ToLongDateString();


        }

        void labelAktar()
        {
            label1.Text = "";
            for (int i = 1; i <= uzunluk; i++)
            {
                label1.Text += "_ ";
            }
        }

        void diziyeAktar()
        {
            for (int i = 0; i < uzunluk; i++)
            {
                harfler[i] = kelime.Substring(i, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            surehak();
           if(textBox1.Text.ToUpper() == kelime.ToUpper())
            {
                bilinenharfler = uzunluk;
            }
            else
            {
                MessageBox.Show("Yanlış Cevap");
            }

            oyunBitti();
        }
        void oyunBitti()
        {
            if (bilinenharfler == uzunluk)
            {
                if(soruSayac < 14)
                {
                    timer1.Stop();
                    MessageBox.Show("BİLDİN TEBRİKLER!");
                    soruSayac++;
                    lblScreen.Text = "";
                    timer2.Stop();
                    textBox1.Enabled = false;
                    button1.Enabled = false;

                    

                    puan += soruPuan;
                    puanLabel.Text = puan.ToString();
                    butonses.Stop();
                    soruGetir();
                    timer1.Start();
                    diziyeAktar();
                    labelAktar();

                    alkisses = new SoundPlayer("alkis.wav");
                    alkisses.Play();

                }
                else if (soruSayac == 14)
                {

                    timer1.Stop();
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }

            }
            if (soruSayac == 14)
            {
               
                timer1.Stop();

                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            if (kalansure <= 0)
            {
                timer1.Stop();
                MessageBox.Show("KELİMEYİ BULAMADIN");
                puan -= soruPuan;
                
                kalansure = 60;
                puanLabel.Text = puan.ToString();
                soruGetir();
                timer1.Start();
                diziyeAktar();
                labelAktar();
                if(soruSayac == 14)
                {
                    puanEkle(isimText.Text, Convert.ToInt32(puanLabel.Text));
                    timer1.Stop();
                }
            }
            
        }

        static string yazdir(string metin, int indis, string yenideger)
        {
            metin = metin.Remove(indis, 1);
            return metin.Insert(indis, yenideger);
        }
        void ipucu(ArrayList metin, ArrayList kelime,string cumlek)
        { A:
            Random rdr = new Random();
            int rastgeleSayi = rdr.Next(0, metin.Count);
            if(rastgeleSayi < 0 || rastgeleSayi > cumlek.Length)
            {
                goto A;
            }
            else
            {
                string harf = kelime[rastgeleSayi].ToString();
                if (metin[rastgeleSayi].ToString() == "_")
                {
                    metin[rastgeleSayi] = harf;
                    string cumle = "";
                    foreach (var item in metin)
                    {
                        cumle += item + " ";
                    }
                    label1.Text = cumle;
                    soruPuan -= 100;
                    bilinenharfler++;
                }
                else
                {
                    goto A;

                }
            }
  
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void surehak()
        {
            label3.Text = " : " + kalansure;
            

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (isimText.Text != string.Empty)
            {
                timer1.Start();

                adsoyadliste = isimText.Text;
                adsoyadlbl.Text = adsoyadliste;

                puan = 0;
                puanLabel.Text = puan.ToString();
                soruGetir();
                soruSayac = 0;

                labelAktar();
                diziyeAktar();
                
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            oyunBitti();
            surehak();

            if (kalansure > 0)
            {
                kalansure--;
            }


        }

   



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            soruEkleme();
        }

        private void soruEkleme()
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                if (soruEklemeText.Text != string.Empty && cevapEklemeText.Text != string.Empty && puanEklemeText.Text != string.Empty)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO soru_table(soru,cevap,puan) VALUES(@p1,@p2,@p3)";
                    cmd.Parameters.AddWithValue("@p1", soruEklemeText.Text);
                    cmd.Parameters.AddWithValue("@p2", cevapEklemeText.Text);
                    cmd.Parameters.AddWithValue("@p3", puanEklemeText.Text);

                  



                    int ekleme = cmd.ExecuteNonQuery();
                    if (ekleme != 0)
                    {
                        MessageBox.Show("Ekleme Başarılı");
                        soruEklemeText.Text = "";
                        cevapEklemeText.Text = "";
                        puanEklemeText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ekleme Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Boş Kısımları Doldurunuz");
                }
               

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void puanTablosuButton_Click(object sender, EventArgs e)
        {
            puanBastır();
        }

        private void soruGetir()
        {

      
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

            label1.Text = "";
            textBox1.Text = "";
            
            bilinenharfler = 0;
            try
            {
                E:
                if (soruSayac < 2)
                {

                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 4 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 2 && soruSayac < 4)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 5 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 4 && soruSayac < 6)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 6 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 6 && soruSayac < 7)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 7 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 7 && soruSayac < 9)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 8 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 9 && soruSayac < 11)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 9 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if (soruSayac >= 11 && soruSayac < 13)
                {
                    cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM soru_table where LENGTH(cevap) = 10 ORDER BY RAND() LIMIT 1";
                    dr = cmd.ExecuteReader();
                }
                else if(soruSayac ==14)
                {
                    MessageBox.Show("Oyun Bitti Tebrikler");
                    puanEkle(isimText.Text, Convert.ToInt32(puanLabel.Text));
                    timer1.Stop();

                    puanlbl.Text = puan.ToString();
                    kalansurelbl.Text = "" + kalansure;

                    textBox1.Enabled = false;
                    button1.Enabled = false;

                    adsoyadlbl.Visible = true;

                    tarihlbl.Visible = true;
                    tarih2lbl.Visible = true;




                }
            }
            
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            using (cmd)
            {
                using(dr)
                {
                    try
                    {
                        while (dr.Read())
                        {
                            kelime = dr[2].ToString();
                            soru = dr[1].ToString();
                            uzunluk = kelime.Length;
                            harfler = new string[uzunluk];
                            soruPuan = Convert.ToInt32(dr[3]);
                            soruTextBox.Text = soru;

                        }
                        dr.Close();
                    }
                    catch(Exception Err)
                    {
                        timer1.Stop();
                    }
                

                }
            }
               
           
            
        
            connection.Close();

        }
        int sayac = 0;
      

        private void button4_Click(object sender, EventArgs e)
        {
            Random rdr = new Random();
           
            string metin = label1.Text;
          
            ArrayList listarray = new ArrayList();
            ArrayList kelimeArray = new ArrayList();
           
            for (int i = 0; i < metin.Length; i++)
            {
                if(metin.Substring(i,1) == "" || metin.Substring(i, 1) == " ")
                {
                    
                }
                else
                {
                    listarray.Add(metin.Substring(i, 1));
                    sayac++;
                }
             
            }

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime.Substring(i, 1) != string.Empty)
                {
                    kelimeArray.Add(kelime.Substring(i, 1));
                }
            }
            int rsayi = rdr.Next(listarray.Count);
           
         
            ipucu(listarray, kelimeArray, kelime);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            butonses = new SoundPlayer("butonses.wav");
            butonses.Play();
            

            textBox1.Enabled = true;
            button1.Enabled = true;
            second = 20;
            timer2.Start();

            timer1.Stop();
            


        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = second--.ToString();
            if(second <= 0)
            {
                timer2.Stop();
                puan -= soruPuan;
                puanLabel.Text = puan.ToString();
                soruGetir();
                timer1.Start();
                diziyeAktar();
                labelAktar();
                lblScreen.Text = " ";

                aaases = new SoundPlayer("aaa.wav");
                aaases.Play();
            }
        }

        private void isimText_TextChanged(object sender, EventArgs e)
        {

        }

        private void puanlbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void adsoyadlbl_Click(object sender, EventArgs e)
        {

        }

        private void puanEkle(string adsoyad,int puan)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }


            cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "INSERT INTO puan_tablo(adsoyad,puan) VALUES(@p1,@p2)";
            cmd.Parameters.AddWithValue("@p1", adsoyad);
            cmd.Parameters.AddWithValue("@p2", puan);


           cmd.ExecuteNonQuery();
         
            

        }

        private void puanBastır()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }


            cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * from puan_tablo";
            dr = cmd.ExecuteReader();
            

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT Dosyalar | *.txt";
            saveFileDialog.Title = "Puan Tablosu";
            saveFileDialog.ShowDialog();

            StreamWriter sw = new StreamWriter(saveFileDialog.FileName); 

            while(dr.Read())
            {
                sw.WriteLine(dr[1].ToString() + " Puanı : " + dr[2].ToString());
            
            }
            dr.Close();
            dr.Dispose();
            sw.Close();
           

            MessageBox.Show("İşlem Tamamlandı");


           
        }

        
    }
}
