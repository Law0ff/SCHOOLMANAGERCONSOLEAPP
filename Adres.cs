using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamaG031
{
    internal class Adres
    {
         public string Il { get; set; }
         public string Ilce  { get; set; }
         public string Mahalle{ get; set; }



        public  Adres (string il,string ilçe,string mahalle)
           {
             this.Il = il;
               this.Ilce = ilçe;
              this.Mahalle = mahalle;
            }
       
    }
}
