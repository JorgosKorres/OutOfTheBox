using OutOfTheBox.database;
using OutOfTheBox.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox
{
    internal class GevangenisApi
    {
        IConnection conn;
        public GevangenisApi(IConnection connection)
        {
            this.conn = connection;
        }

        // Create methoden
        public void CreateGevangenis(string naam, int maxCapaciteit)
        {
            conn.CreateGevangenis(naam, maxCapaciteit);
        }
    }
}
