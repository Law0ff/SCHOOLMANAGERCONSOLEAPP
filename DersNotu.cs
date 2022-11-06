using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamaG031
{
    internal class DersNotu
    {
        public float Not { get; set; }
        public string DersAdi;
        public DersNotu(string dersAdi, float not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }
    }
}
