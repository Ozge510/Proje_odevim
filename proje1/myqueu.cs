using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public class myqueu
    {
        veri bas;
        veri son;

        public myqueu(string girdi)
        {
            bas = new veri(girdi);
            son = bas;
            son.set_ileri(bas);
        }

        public void ekle(string girdi)
        {
            son.set_ileri(new veri(girdi));
            son = son.get_ileri();
            son.set_ileri(bas);
        }
        public void cikar()
        {
            if (bas == null)
            {
                return; // boş bir queue çıkarılma yapılmaz.
            }
            if (bas.get_ileri() == null)
            {
                bas = null; // tek bir eleman varsa ilerisi olamyacağı için burda direk null yapıyoruz ve fonksiyonu durduruyoruz.
                return;
            }
            veri temp = bas.get_ileri();
            bas = null;
            bas = temp;
        }
        public string queue_yazdir()
        {
            String veriler = "";
            veri temp = bas;
            veri temp2 = bas;
            if (temp != null)
            {
                veriler += "(" + temp.get_veri() + ") ";
                temp = temp.get_ileri();
            }
            else
            {
                return veriler;
            }
            while (temp != null && temp != temp2)
            {
                veriler += "(" + temp.get_veri() + ") "; temp = temp.get_ileri();
            }
            return veriler;
        }
    }
}
