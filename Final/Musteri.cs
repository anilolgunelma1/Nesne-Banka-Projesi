using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Musteri
    {//musteri clasında adSoyad hesapno parola verileri constructor ile tutuldu 
        Dosya d = new Dosya();
        public string hesapNo { get; set; }
        public string adSoyad { get; set; }
        private string parola;
        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }
        public Dictionary<string, Hesap> hesap = new Dictionary<string, Hesap>();
        public Musteri(string hesapNo,string adSoyad,string Parola,Dictionary<string,Hesap>Liste)
        {
            this.hesapNo = hesapNo;
            this.adSoyad = adSoyad;
            this.Parola = Parola;
            hesap = Liste;
        }
    }
}
