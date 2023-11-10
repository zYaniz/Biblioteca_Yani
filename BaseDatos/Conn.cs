using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestiónBiblioteca_Yani.BaseDatos
{
    class Conn
    {
        Conn()
        {

        }
        public static string GetConnectionStrings()
        {
            string resultado = "";
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                resultado = settings[0].ConnectionString;
            }
            return resultado;
        }
    }
}
