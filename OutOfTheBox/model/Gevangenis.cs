using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Gevangenis
    {
        int id;
        string naam;
        int maxCapaciteit;

        public Gevangenis(int id, string naam, int maxCapaciteit)
        {
            this.id = id;
            this.naam = naam;
            this.maxCapaciteit = maxCapaciteit;
        }
    }
}
