using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_N102_SystemIOWinForm
{
    public class Personel
    {
        public int İd { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string adres { get; set; }
        public string firmaAdi { get; set; }
        public string ulke { get; set; }
        public override string ToString()
        {
            return isim + " " + soyisim;
        }

        public string personelBilgiGetir ()
        {
            return string.Format("İsim:{0} Soyisim:{1} Email Adres:{2} Firma Adı:{3} Ülke:{4}", isim, soyisim, email, firmaAdi, ulke);
        }


    }
}
