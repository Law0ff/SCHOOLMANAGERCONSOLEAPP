using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamaG031
{
    internal class Okul
    {
        public bool OgrenciVarMi;
        //veriyi yöneteceğimiz, veriden veri üreteceğimiz/ güncelleyebileceğimiz class
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        public List<Ogrenci> YeniListe = new List<Ogrenci>();
        public List<Adres> Adresler = new List<Adres>();
        
        public void OgrenciEkle(int no, string ad, string soyad, SUBE sube, CINSIYET cinsiyet, DateTime dog_trh)
        {
            this.Ogrenciler.Add(new Ogrenci(no, ad, soyad, sube, cinsiyet, dog_trh));
        }
        
        public void NotEkle(int no, string ders, float not)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            DersNotu dn = new DersNotu(ders, not);
            o.Notlar.Add(dn);
        }
        public void AdresEkle(int no,string il,string ilce,string mahalle)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            Adres adr = new Adres(il, ilce, mahalle);
            o.Adres.Add(adr);
        }
        public void ListeYazdir(List<Ogrenci> liste)
        {
            Console.WriteLine("Sube".PadRight(5) + "No".PadRight(5) + "Adı".ToString().PadRight(5) + "SOYADI".ToString().PadRight(10)
                + "NOR ORTALAMASI".PadRight(5) + "OKUDUĞU KİTAP SAYISI".PadRight(5) );
            Console.WriteLine("".PadRight(52, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(5) + item.Ad.PadRight(10) + item.Soyad.ToString().PadRight(5) + item.Cinsiyet.ToString().PadRight(10)
                    + item.Sube.ToString().PadRight(5));  //item.NotOrtalamasi.ToString().PadRight(5));
            }
        }
        public void AdresYazdir()
        {
            Console.WriteLine("Sube".PadRight(5) + "No".PadRight(5) + "Adı".ToString().PadRight(5) + "SOYADI".ToString().PadRight(10)
                + "ŞEHİR".PadRight(10) + "SEMT".PadRight(5));
            Console.WriteLine("".PadRight(52, '-'));

            YeniListe = Ogrenciler.Where(item => item.Adres).ToList();
            
        }

        public void SubeyeGoreOgrenci()
        {
            Console.WriteLine("2-Subeye Göre Ögrencileri Listele --------------------------------------------");
            Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
            string secim = Console.ReadLine().ToUpper();
            switch (secim)
            {
                case "A":                   
                    YeniListe = Ogrenciler.Where(A => A.Sube == SUBE.A).ToList();
                    ListeYazdir(YeniListe);
                    break;
                case "B":
                    YeniListe = Ogrenciler.Where(A => A.Sube == SUBE.B).ToList();
                    ListeYazdir(YeniListe);
                    break;
                case "C":
                    YeniListe = Ogrenciler.Where(A => A.Sube == SUBE.C).ToList();
                    ListeYazdir(YeniListe);
                    break;
                case "":
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin.");
                    break;
                   
            }
        }

        public void CinsiyetineGoreOgrenci()
        {
            Console.WriteLine("3 - Cinsiyete Göre Öğrencileri Listele---------------------------------------- -");
            Console.WriteLine("Listelemek istediğiniz cinsiyeti girin (K/E):");
            string secim = Console.ReadLine().ToUpper();
            switch (secim)
            {
                case "E":
                    YeniListe = Ogrenciler.Where(a => a.Cinsiyet == CINSIYET.Erkek).ToList();
                    ListeYazdir(YeniListe);
                    break;
                case "K":
                    YeniListe = Ogrenciler.Where(a => a.Cinsiyet == CINSIYET.Kiz).ToList();
                    ListeYazdir(YeniListe);
                    break;
                case "":
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin.");
                    break;

            }

        }

        public void DogumYılınaGore()
        {
            Console.WriteLine("4-Dogum Tarihine Göre Ögrencileri Listele ------------------------------------");
            Console.WriteLine("Hangi tarihten sonraki ögrencileri listelemek istersiniz:");
            DateTime secim = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;         
            int GirilenYıl = secim.Year;
            if (true)
            {
                YeniListe = Ogrenciler.Where(item => GirilenYıl <= item.DogumTarihi.Year).ToList();
                ListeYazdir(YeniListe);
            }
           

        }

        public void Ogrencibul(int numara)
        {

                Ogrenci ogr = null;
                foreach (Ogrenci item in Ogrenciler)
                {
                    if (numara == item.No)
                    {
                        ogr = item;
                                             
                    }
                    
                }
            if (ogr != null)
            {
                Console.WriteLine("Ögrencinin Adı Soyadı:" + ogr.Ad + " " + ogr.Soyad);
                Console.WriteLine("Ögrencinin Subesi: " + ogr.Sube);
                OgrenciVarMi = true;


            }
            else if (ogr == null)
            {
                Console.WriteLine("Bu numarada bir ögrenci yok.Tekrar deneyin.");
                
                OgrenciVarMi = false;

            }
            


        }

        public void TumOgrenciListele()
        {
            ListeYazdir(Ogrenciler);
        }

        
            
        }


    }

