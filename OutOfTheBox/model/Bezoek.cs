using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Bezoek
    {
        int id;
        int gevangene;
        string bezoeker;
        DateTime datum;

        public int Gevangene { get => gevangene; set => gevangene = value; }

        public Bezoek(int id, int gevangene, string bezoeker, DateTime datum)
        {
            this.id = id;
            this.Gevangene = gevangene;
            this.bezoeker = bezoeker;
            this.datum = datum;
        }

      
    }
}
