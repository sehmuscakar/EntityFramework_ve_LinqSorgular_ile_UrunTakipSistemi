using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTİTİYprojeuygulama
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        dbEntitiyUrunEntities1 db = new dbEntitiyUrunEntities1();
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.tblkategori.Count().ToString();//kategorileri sayar kaç tane olduğu 
            label3.Text = db.tblurun.Count().ToString();//ürünleri sayar kaç tane olduğu
            label11.Text = db.tblmusteri.Count(x => x.DURUM == true).ToString();//burda durumu 1 olanları getiri kac taneyse landa
            label9.Text = db.tblmusteri.Count(x => x.DURUM == false).ToString();//burda da durumu false olanları getirir 
            label5.Text = db.tblurun.Sum(y=>y.STOK).ToString();// burdada toplam stoku verir 
            // bu x ve y farklı bir harf te olabilir kod mantığı aynı buna sonra bak istersen kad yapısı 
            label29.Text = db.tblsatiş.Sum(z => z.FİYAT).ToString()+ " TL";//burda da kaadaki tutarı taopladık
            label13.Text = (from x in db.tblurun orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            // şimdi burda tblurun tablosunda fiyata göre sıralama yaptık bu sıralamayı  z den a ya 
            //yani en yüksekten an aza sıraladık bunu x içine atadık sonra x ile bu en yükseğiin adını seçtik
            //FirstOrDefault(); bu metotlada en yüksek sıralamda ki bir tane ise eğer bu metotla çağırdık 
            //label tek değer alır unutma 
            label15.Text = (from x in db.tblurun orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            //burdada  a dan z ye yani en düşükten en yüseğe sıraldık 
            label7.Text = db.tblurun.Count(x => x.KATEGORİ == 1).ToString();//beyaz eşya sayısını verir 
            label23.Text = db.tblurun.Count(x => x.URUNAD == "BUZDOLABI").ToString();//toplam buzdolabı sayısını verir 
            label31.Text = (from x in db.tblmusteri select x.SEHİR).Distinct().Count().ToString();// db.musteri leri x içine atadık sonra x.sehir ile sectik /distinç ile aynı şehirleri tek getirsin 
                                                                                                  //sonra count ile saydık kaç taneyse sonra yazdırdık 
            label25.Text = db.markagetir().FirstOrDefault();//markagetir() bu oluşturduğumuz prosedür 


        }
    }
}
