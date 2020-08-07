using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Policy;

namespace Final
{
    class Dosya
    {//sha ile sifrelenme yapıldı.
        public string Sha384(string password)
        {
            using (SHA384 sha384Hash = SHA384.Create())
            {

                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha384Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;

            }
        }
        public void Yazdır(Musteri musteri)
        {
            //sifrelenmiş veriler autha yazdırıldı.
         
            
            try
            {
                string dosyayolu = @"C:/Final/auth.txt";
                FileStream fs = new FileStream(dosyayolu, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(musteri.hesapNo + "," + musteri.Parola);
                
                sr.Close();
                fs.Close();
     
            }          
            catch (Exception k)
            {
                Console.WriteLine(k.Message);
                
            }
         

        }
       
          
        }
       
    }



