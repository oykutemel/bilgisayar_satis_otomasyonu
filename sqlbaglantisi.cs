using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bilgisayar_satış
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DJMBLC5;Initial Catalog=DboBilgisayarOtomasyon;Integrated Security=True");
            baglanti.Open();
            return baglanti;     
        }
    }
}
