using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        { 
            Dosya dt = new Dosya();
            Dictionary<string, Hesap> a = new Dictionary<string, Hesap>();
            GirisEkran ekran = new GirisEkran();
            
           
            a.Add("TR610003200013900000326785", new HesapTR("TR610003200013900000326785", 350));
            a.Add("TR300003200016420000326785", new HesapEURO("TR300003200016420000326785", 8000));
            Musteri musteri = new Musteri("326785", "İsmail Borozan", dt.Sha384("IsmB1982"),a);
            dt.Yazdır(musteri);
            a.Clear();
             a.Add("TR610008324560000000400129", new HesapTR("TR610008324560000000400129", 2980.45));
            Musteri musteri2 = new Musteri("400129", "Kamile Hurşitgiloğulları", dt.Sha384("12Hrst34"), a);
            dt.Yazdır(musteri2);
            a.Clear();
            a.Add("TR610007222250001200388000", new HesapTR("TR610007222250001200388000", 19150.00));
            a.Add("TR300007222249000001388000", new HesapEURO("TR300007222249000001388000", 52.93));
            a.Add("TR300008222266600002388000", new HesapUSD("TR300008222266600002388000", 2850.00));
            Musteri musteri3 = new Musteri("388000", "Zebercet Bak", dt.Sha384("zb123456"), a);
            dt.Yazdır(musteri3);
            a.Clear();
            a.Add("TR610032455466661200201005", new HesapTR("TR610032455466661200201005", 666.66));
            a.Add("TR300032455410080003201005", new HesapUSD("TR300032455410080003201005", 10000.00));
            Musteri musteri4 = new Musteri("201005", " Naz Gül Uçan", dt.Sha384("Mordor99"), a);
            dt.Yazdır(musteri4);
            a.Clear();
            Console.WriteLine("Giriş Ekranına Hoşgeldiniz");
            
            ekran.deneme();
            Console.ReadKey();


            
        }
    }
}
