using OutOfTheBox.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfTheBox
{
    internal class OutOfTheBoxApi
    {
        public IConnection connection;
        public GevangenisApi gevangenisApi;

        public OutOfTheBoxApi(string connectionString)
        {
            connection = new MySqlDbConnection(connectionString);
            connection.getConnection();
            gevangenisApi = new GevangenisApi(connection);
        }
    }
}
