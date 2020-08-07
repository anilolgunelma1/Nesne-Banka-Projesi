using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace Final
{
    class GirisEkran
    {//Giriş Ekranı Oluşturularak İD Sifre kontrolü yapıldı.
       public void deneme()
        {
            //authdaki veriler satır sütün olarak diziye çekildi.
            try
            {
                int i = 0;
                string[,] A = new string[4,2];
                Dosya dt = new Dosya();
                string dosyayolu = @"C:/Final/auth.txt";
                FileStream fs = new FileStream(dosyayolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
               
                string yazi = sr.ReadLine();

                while (yazi != null)
                {
                    string[] satirlar = yazi.Split(',');

                    for (int j = 0; j < 2; j++)
                    {
                        A[i, j] = satirlar[j];

                    }
                    yazi = sr.ReadLine();
                    i++;


                }

                //Hesap id ve sifresi kulanıcının girdiği sifre ve ıd ile karsılastırıldı giriş ekranında.
                //sifre sha ile sifrelendi.
                
                Console.WriteLine("İd giriniz");
                string İD = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Şifre giriniz");
                string password = Convert.ToString(Console.ReadLine());
                string sifre = dt.Sha384(password);
               

                
                for (i = 0; i < 4; i++)
                {
                    if (A[i, 0] == İD && A[i, 1] == sifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                       

                    }
                    
                }
                
            }
            catch (Exception rt)
            {

                Console.WriteLine(rt.Message);
            }
            




        }
        
       
        


    }
}
