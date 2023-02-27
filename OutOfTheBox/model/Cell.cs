using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox.model
{
    internal class Cell
    {
        int id;
        int gevangenis;
        int celtype;

        public Cell(int id, int gevangenis, int celtype)
        {
            this.id = id;
            this.gevangenis = gevangenis;
            this.celtype = celtype;
        }
    }
}
