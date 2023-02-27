using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Geslacht
    {
        int id;
        string geslacht;

        public Geslacht(int id, string geslacht)
        {
            this.id = id;
            this.geslacht = geslacht;
        }
    }
}
