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
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbEntitiyUrunEntities1 db = new dbEntitiyUrunEntities1();
            var sorgu = from x in db.tbladmin where x.KULLANICI == textBox1.Text && x.SİFRE == textBox2.Text select x;//coğunlukla select sonlarda yazılır yani o değişkeni seçer gibi 
            if (sorgu.Any())//Any RETURN GİBİ DÜŞÜN // any yapmazsan yukardaki satır çlışmaz 
            {
                frmanaform fr = new frmanaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
           
        }
    }
}
