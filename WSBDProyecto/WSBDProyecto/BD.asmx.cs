using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WSBDProyecto
{
    /// <summary>
    /// Descripción breve de BD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BD : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet GetData()
        {
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Data Source=401-20; Initial Catalog='TEST'; Trusted_Connection = True;";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_USERS", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}