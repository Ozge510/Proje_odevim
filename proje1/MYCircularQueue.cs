using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public partial class MYCircularQueue : Component
    {
        public myqueu tutulan_veri = new myqueu("");
        

        public String EklenecekVeri {
            get { veriler = tutulan_veri.queue_yazdir(); return EklenecekVeri; }   // get method
            set { tutulan_veri.ekle(EklenecekVeri); veriler = tutulan_veri.queue_yazdir();  EklenecekVeri = value; }
        } //yeni eklecenk veri

        public String veriler { get; set; } //guncel veriler

        public bool ekle
        {
            get { return ekle; }   // get method
            set { tutulan_veri.ekle(EklenecekVeri);  ekle = value;}
        }// set method}
        public MYCircularQueue()
        {
            InitializeComponent();
        }

        public MYCircularQueue(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
