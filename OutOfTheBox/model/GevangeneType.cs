using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class GevangeneType
    {
        int id;
        int geslacht;

        public GevangeneType(int id, int geslacht)
        {
            this.id = id;
            this.geslacht = geslacht;
        }
    }
}
