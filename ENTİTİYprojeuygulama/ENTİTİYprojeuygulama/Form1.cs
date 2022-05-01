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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbEntitiyUrunEntities1 db = new dbEntitiyUrunEntities1();//sınıfımdan db adlı nesne türetim modelll olduğunda oldu 
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.tblkategori.ToList(); //var kategoriler değişkenle oluşturduk 
            // veri tipi belli olmadığı için var kullandık var hepsini kapsar gibi düşün 
            //db nesnesinden kategorilere ondanda listeleme metodunu kulandık 
            dataGridView1.DataSource = kategoriler;// datagridin veri kaynağı kategoriler 

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tblkategori t = new tblkategori();//ekleyebilmem için sutunların bulunduğu tablodan nesne oluşturmam lazım ki sutunlara erişebiliyim 
            t.AD = textBox2.Text;
            db.tblkategori.Add(t);
            db.SaveChanges();//değişiklikleri kaydet gibi bi anlamı var 
            MessageBox.Show("KATEGORİ EKLENDİ");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);// int türünde x oluşturduk int olmasının sebibi sql de id int olduğu için id girecez buraya 
            var ktgr = db.tblkategori.Find(x);//textbox1 girilen id değerini bul 
            db.tblkategori.Remove(ktgr);//sonra bu değeri kaldır 
            db.SaveChanges();//değişklikleri kaydet 
            MessageBox.Show("kategori silindi");

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);// int türünde x oluşturduk int olmasının sebibi sql de id int olduğu için id girecez buraya 
            var ktgr = db.tblkategori.Find(x);//textbox1 girilen id değerini bul 
            ktgr.AD = textBox2.Text;//textbox2 dekini ktgr.ad ye aktar 
            db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı");

        }
    }
}
