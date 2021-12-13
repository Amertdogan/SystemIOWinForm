using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_N102_SystemIOWinForm
{
    public partial class Form1 : Form
    {
        DataIslemleri dataIslemleri;
        List<Personel> personelListesi;
        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new DataIslemleri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpersonelgetir_Click(object sender, EventArgs e)
        {
            personelListesi = dataIslemleri.personelGetir(150);
            lstpersonel.DataSource = personelListesi;
        }

        private void lstpersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel = (Personel)lstpersonel.SelectedItem;

            txtisim.Text = secilenPersonel.isim;
            txtsoyisim.Text = secilenPersonel.soyisim;
            txtemailadres.Text = secilenPersonel.email;
            txtfirma.Text = secilenPersonel.firmaAdi;
            txtulke.Text = secilenPersonel.ulke;
        }

        private void btnpersonelKaydet_Click(object sender, EventArgs e)
        {
            dataIslemleri.personelKaydet(@"c:\NetworkAkademi", personelListesi);
        }
    }
}
