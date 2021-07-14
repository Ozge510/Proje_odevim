using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    /// <summary>
    /// Verileri tutuldupu kutular 
    /// </summary>
    public class veri
    {
        string icindeki_veri;
        veri ileri;
        public veri(string girdi)
        {
            ileri = null;
            icindeki_veri = girdi;
        }
        public void set_ileri(veri yeni_ileri)
        {
            ileri = yeni_ileri;
        }
        public veri get_ileri()
        {
            return ileri;
        }
        public string get_veri()
        {
            return icindeki_veri;
        }
    }
}
