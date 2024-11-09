using System;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkWithJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText("data.json");
            //Bu sat�r, "data.json" adl� dosyadan t�m i�eri�i okur ve bunu bir string de�i�kenine (jsonString) atar.
            List<Ogrenci> people = JsonSerializer.Deserialize<List<Ogrenci>>(jsonString);

            //JsonSerializer.Deserialize<List<Ogrenci>>(jsonString): Bu metod, jsonString i�indeki
            //JSON verisini al�r ve bunu List<Ogrenci> t�r�nde bir nesneye d�n��t�r�r.
            //JSON verisi, Ogrenci s�n�f�n�n �zelliklerine g�re deserialize edilir.

            foreach (var item in people)
            { 
            
               list.Add(item);
            
            }
            dataGridView1.DataSource = list;    

        }
        Ogrenci ogrenci = new Ogrenci();
        List<Ogrenci> list = new List<Ogrenci>();
        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci.Adi = txtAd.Text;
            ogrenci.Soyadi = txtSoyad.Text;
            txtAdres.Text = txtAdres.Text;
            list.Add(ogrenci);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;

        }
        private void button2_Click(object sender, EventArgs e)
        {
             string jsonString = JsonSerializer.Serialize(list);
            //JsonSerializer.Serialize(list) ifadesi, list adl� listeyi JSON format�nda bir dizi (string)
            //haline getirir. JsonSerializer s�n�f�,
            //.NET i�inde yer alan ve veri yap�lar�n� JSON format�na d�n��t�ren bir yard�mc� s�n�ft�r.
            File.WriteAllText("data.json", jsonString);
            //File.WriteAllText metodu, belirtilen dosya yoluna ("data.json") bir metin yazma i�lemi ger�ekle�tirir.

            //JSON format�nda elde edilen jsonString verisi, "data.json" adl� dosyaya yaz�l�r. E�er bu dosya mevcutsa, i�erik �zerine yaz�l�r;
            //yoksa yeni bir dosya olu�turulur.
            MessageBox.Show("Veri JSON olarak kaydedildi.");
            
        }
    }
}
