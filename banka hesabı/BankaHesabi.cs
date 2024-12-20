using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_hesabı
{
    internal class BankaHesabi
    {
        public decimal Bakiye { get; private set; }

        
        public void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
        }

        
        public bool ParaCek(decimal miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                return true; 
            }
            return false; 
        }
    }
}
