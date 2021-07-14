using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    /// <summary>
    /// myque sınıfı veri sınıfından iki tane sınıf alıyor bu sınıflar eklenen ilk veri ve son veri olarak tutuluyor, ilk veriyi tutmamızın amacı ilk girien ilk çıktığı içindir
    /// her veri eklendiğinde veri eklendikten sonra son eklenen verinin ilerisi tekrar baş kısmı gösteriyor buda circle(yuvarlak ) bir yapı olmasını sağlıyor.
    /// </summary>
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
        /// <summary>
        ///     Verinin son verisine bir veri ekliyoruz ve eklenen veriyi tekrar başı göstermesini sağlıyoruz
        /// </summary>
     
        public void ekle(string girdi)
        {
            son.set_ileri(new veri(girdi));
            son = son.get_ileri();
            son.set_ileri(bas);
        }
        //
        /// <summary>
        ///   ilk veriyi çıkarırıyoruz, ilk veriyi göstern bas eleman artık onun ilerisi oluyor bundan dolayı silmeden önce onun bir ilerisini kayıt ediyoruz.
        /// </summary>
      
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
        /// <summary>
     
        /// oluşan queue yapısını görüntüleyebilmek için verileri string şeklinde geri döndürüyoruz.
        /// </summary>
        /// <returns></returns>
        
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
