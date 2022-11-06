using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamaG031
{
    internal class Uygulama
    {
        // DERSLER EKLENİCEK , ADRESLER EKLENİCEK , OGRENCİ BULMA METODU DÜZENLENİCEK , ORTALAMA HESAPLANICAK , KISACA HER ŞEY YAPILCAK EĞER YAPMAZSAN KAFANI SİKEYİM SENİN 

        public Okul Okul = new Okul();

        public void Calistir()
        {
            SahteVeriGir();
            Menu();
            bool sonuc = true;
            while (sonuc)
            {

                string secim = SecimAl();
                switch (secim)
                {
                    case "1": //ÖĞRENCİ LİSTELE
                        Okul.TumOgrenciListele();
                        break;
                    case "2"://Şubeye göre öğrenci listele
                        Okul.SubeyeGoreOgrenci();
                        break;
                    case "3"://Cinsiyete göre öğrenci listele
                        Okul.CinsiyetineGoreOgrenci();
                        break;
                    case "4"://doğum yılına göre öğrenci listele
                        Okul.DogumYılınaGore();
                        break;
                    case "5"://illere göre öğrenci listele
                        Okul.AdresYazdir();
                        break;
                    case "6"://tüm notlarla öğrencileri listele
                        break;
                    case "7"://okuduğu kitapları listele
                        break;
                    case "8"://en yüksek 5 notlu öğrenci listele
                        break;
                    case "9"://en düşük 3 notlu öğrenci list
                        break;
                    case "10"://şubedeki en yüksek 5 notlu öğrencili listele
                        break;
                    case "11"://Şubedeki en düşük notlu 3 öğrenciyi listele
                        break;
                    case "12"://Öğrencinin not ortalamasını gör
                        break;
                    case "13"://Şubenin not ortalamasını gör
                        break;
                    case "14"://Öğrencinin okuduğu son kitabı gör
                        break;
                    case "15"://Öğrenci ekle

                        break;
                    case "16"://Öğrenci güncelle (yeni öğrenci yaratılmayacak, var olan öğrenci nesnesi üzerinden güncelleme yapılacak.)
                        break;
                    case "17"://Öğrenci sil
                        break;
                    case "18"://Öğrencinin adresini gir
                        AdresEkle();
                        break;
                    case "19"://Öğrencinin okuduğu kitabı gir
                        break;
                    case "20"://Öğrencinin notunu gir  (Metot ile giriş yapılacak)
                        NotEkle();
                        break;
                    case "ÇIKIŞ":
                        return;
                    case "LİSTE":
                        sonuc = true;
                        break;
                    case "":
                        Console.Write("Menüyü tekrar listelemek için 'liste', çıkıs yapmak için 'çıkıs' yazın.");
                        break;



                }
            }
        }
        public void Menu()
        {
            Console.WriteLine("            ------Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Bütün öğrencileri listele");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele(Alfabetik sıralama olacak )");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele(Derse göre sıralayıp listelenecek)");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör(Öğrenciye ait ortalama özelliği olacak, set özelliği olmayacak, get özelliği içinde hesaplanıp döndürülecek)");
            Console.WriteLine("13 - Şubenin not ortalamasını gör");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör");
            Console.WriteLine("15 - Öğrenci ekle");
            Console.WriteLine("16 - Öğrenci güncelle(yeni öğrenci yaratılmayacak, var olan öğrenci nesnesi üzerinden güncelleme yapılacak.)");
            Console.WriteLine("17 - Öğrenci sil");
            Console.WriteLine("18 - Öğrencinin adresini gir(Öğrencinin adresi farklı bir class olacak )");
            Console.WriteLine("19-Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("20-Öğrencinin notunu gir(Metot ile giriş yapılacak)");
            Console.WriteLine();
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");

        }
        public void SahteVeriGir()
        {
            Okul.OgrenciEkle(1, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
            Okul.OgrenciEkle(2, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
            Okul.OgrenciEkle(3, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
            Okul.OgrenciEkle(4, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
            Okul.OgrenciEkle(5, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
            Okul.OgrenciEkle(6, "Emre", "Erdem", SUBE.A, CINSIYET.Erkek, new DateTime(2000, 05, 12));
        }

        public void NotEkle()
        {
            bool sonuc = true;
            while (sonuc)
            {
                Console.Write("Ögrencinin numarasi: ");
                int no = int.Parse(Console.ReadLine());
                Okul.Ogrencibul(no);
                
                if (Okul.OgrenciVarMi == true)
                {

                    Console.WriteLine();
                    Console.Write("Not eklemek istediğiniz ders:");
                    string ders = Console.ReadLine();
                    Console.Write("Eklemek istediginiz not adedi: ");
                    int adet = int.Parse(Console.ReadLine());
                    int not;
                    for (int i = 1; i <= adet; i++)
                    {
                        Console.Write(i + ".Notu girin:  ");
                        not = int.Parse(Console.ReadLine());
                        Okul.NotEkle(no, ders, not);
                    }
                    sonuc = false;
                    break;
                }
                
                

            }
            

        }
        public void AdresEkle()
        {
                bool sonuc = true;
                while (sonuc)
                {
                    Console.Write("Ögrencinin numarasi: ");
                    int no = int.Parse(Console.ReadLine());
                    Okul.Ogrencibul(no);

                    if (Okul.OgrenciVarMi == true)
                    {

                        Console.WriteLine();
                        Console.Write("İL: ");
                        string il = Console.ReadLine();
                        Console.Write("İLÇE: ");
                        string ilce = Console.ReadLine();
                        Console.Write("MAHALLE: ");
                        string mahalle = Console.ReadLine();
                        Okul.AdresEkle(no,il, ilce, mahalle);
                        sonuc = false;
                        break;
                    }

                }
   
        }
        public string SecimAl()
            {
                Console.WriteLine();
                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().ToUpper();
                return giris;
            }



        }
    }


