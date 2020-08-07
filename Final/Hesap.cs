using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{// ana clas oluşturuldu
    abstract class Hesap
    {
       
        public string IBAN { get; set; }
        public double miktarIBAN { get; set; }
       
        public Hesap(string IBAN,double miktarIBAN)
        {
            this.IBAN = IBAN;
            this.miktarIBAN = miktarIBAN;
        }

    }
}
