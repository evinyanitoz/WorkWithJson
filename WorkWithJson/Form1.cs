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
            //Bu satýr, "data.json" adlý dosyadan tüm içeriði okur ve bunu bir string deðiþkenine (jsonString) atar.
            List<Ogrenci> people = JsonSerializer.Deserialize<List<Ogrenci>>(jsonString);

            //JsonSerializer.Deserialize<List<Ogrenci>>(jsonString): Bu metod, jsonString içindeki
            //JSON verisini alýr ve bunu List<Ogrenci> türünde bir nesneye dönüþtürür.
            //JSON verisi, Ogrenci sýnýfýnýn özelliklerine göre deserialize edilir.

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
            //JsonSerializer.Serialize(list) ifadesi, list adlý listeyi JSON formatýnda bir dizi (string)
            //haline getirir. JsonSerializer sýnýfý,
            //.NET içinde yer alan ve veri yapýlarýný JSON formatýna dönüþtüren bir yardýmcý sýnýftýr.
            File.WriteAllText("data.json", jsonString);
            //File.WriteAllText metodu, belirtilen dosya yoluna ("data.json") bir metin yazma iþlemi gerçekleþtirir.

            //JSON formatýnda elde edilen jsonString verisi, "data.json" adlý dosyaya yazýlýr. Eðer bu dosya mevcutsa, içerik üzerine yazýlýr;
            //yoksa yeni bir dosya oluþturulur.
            MessageBox.Show("Veri JSON olarak kaydedildi.");
            
        }
    }
}
