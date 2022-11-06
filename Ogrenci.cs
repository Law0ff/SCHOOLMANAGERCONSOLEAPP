using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamaG031
{
    internal class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public SUBE Sube { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        
        //public string Adres = new Adres();
        //public float NotOrtalamasi
        //{
        //    get
        //    {
        //        return this.Notlar.Average(s => s.Not);
        //    }
        //}
        public List<Adres> Adres = new List<Adres>();
        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();
        public Ogrenci(int no, string ad, string soyad, SUBE sb, CINSIYET cins, DateTime d_tarih)
        {
            this.Sube = sb;
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyet = cins;
            this.DogumTarihi = d_tarih;
            
            
            
        }
        
    }
    enum SUBE
    {
        Empty, A, B, C
    }
    enum CINSIYET
    {
        Empty, Kiz, Erkek
    }
    
    
}
