using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class GevangenisMaxCapaciteit
    {
        int id;
        int maxCapaciteit;
        bool zitVol;

        public GevangenisMaxCapaciteit(int id, int maxCapaciteit)
        {
            this.id = id;
            this.maxCapaciteit = maxCapaciteit;
            this.zitVol = false;
        }
    }
}
