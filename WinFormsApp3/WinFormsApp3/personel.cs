using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class personel
    {
        public personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.yas = gYas;
            this.mesai = gMesai;
            this.unvan = gUnvan;

        }
        string ad;
        string adres;
        int yas;
        int mesai;
        string unvan;
        public string Ad
        {
            get => ad;
            set => ad = value;
        }
      
        public string Adres
        {
            get => adres;
            set => adres = value;
        }
      
        public int Yas
        { 
            get => yas;
            set => yas = value;
        }
        public string Unvan { get => unvan; set => unvan = value; }
        public int Mesai { get => mesai; set => mesai = value; }
     

        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }

        public void ucretHesapla(int ekUcret)
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }


    }

   
}
