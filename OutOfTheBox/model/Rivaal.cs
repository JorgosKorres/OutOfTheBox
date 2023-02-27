using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Rivaal
    {
        int id;
        int gevangene;
        int rivaal;

        public Rivaal(int id, int gevangene, int rivaal)
        {
            this.id = id;
            this.gevangene = gevangene;
            this.rivaal = rivaal;
        }
    }
}
