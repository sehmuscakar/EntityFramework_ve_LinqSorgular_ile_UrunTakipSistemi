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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }
        dbEntitiyUrunEntities1 db = new dbEntitiyUrunEntities1();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = db.tblurun.ToList();// böyle yaparak listeleme yapabiliriz
            dataGridView1.DataSource = (from x in db.tblurun
                                        select new
                                        {
                                            x.URUNİD,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            // x.KATEGORİ buyle yapsak rakam tek gelir 
                                            x.tblkategori.AD,
                                            x.DURUM
                                        }
                                        ).ToList();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tblurun t = new tblurun();
            t.URUNAD = txturunad.Text;
            t.MARKA = txturunmarka.Text;
            t.STOK = short.Parse(txturunstok.Text);
            t.KATEGORİ = int.Parse(comboBox1.SelectedValue.ToString());
            t.FİYAT = decimal.Parse(txturunfiyat.Text);
            t.DURUM = true;
            db.tblurun.Add(t);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN SİSTEME KAYDEDİLDİ");

        }

        private void frmurun_Load(object sender, EventArgs e)
        {
            //foreach gibi bi döngü kullanırız 
            var kategoriler = (from x in db.tblkategori
                               select new { x.İD,//id sec 
                                            x.AD  // adı seç 
                                          }
                               ).ToList();// burda listeleme yaptık 

            comboBox1.ValueMember = "İD";//arka planda çalışacak olan değer 
            comboBox1.DisplayMember = "AD"; // ön planda çalışacak olan değer 
            comboBox1.DataSource = kategoriler;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txturunid.Text);
            var urun = db.tblurun.Find(x);
            db.tblurun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN SİLİNDİ");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txturunid.Text);
            var urun = db.tblurun.Find(x);
            urun.URUNAD = txturunad.Text;
            urun.STOK = short.Parse(txturunstok.Text);
            urun.MARKA = txturunmarka.Text;
            db.SaveChanges();
            MessageBox.Show("ürün güncelendi");

        }
    }
}
