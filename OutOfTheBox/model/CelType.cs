using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class CelType
    {
        int id;
        string beschrijving;
        int aantalPersonen;

        public CelType(int id, string beschrijving, int aantalPersonen)
        {
            this.id = id;
            this.beschrijving = beschrijving;
            this.aantalPersonen = aantalPersonen;
        }
    }
}
