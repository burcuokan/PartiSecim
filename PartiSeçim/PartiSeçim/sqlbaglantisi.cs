using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PartiSeçim
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = OKAN; Initial Catalog = SecımProje; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
