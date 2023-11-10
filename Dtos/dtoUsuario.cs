using SistemaGestiónBiblioteca_Yani.BaseDatos;
using SistemaGestiónBiblioteca_Yani.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaGestiónBiblioteca_Yani.Dtos
{
    public class dtoUsuario
    {
        private ConnSQL conn = new ConnSQL();
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool insertarUsuario(clsUsuario usuario)
        {
            try
            {
                string consulta = "EXEC InsertarUsuario " +
                    "'" + usuario.Nombre + "'," +
                    "'" + usuario.Apellido + "'," +
                    "'" + usuario.Cedula + "'," +
                    "'" + usuario.Direccion + "'," +
                    "'" + usuario.Correo + "'," +
                    "'" + usuario.AdicionadoPor + "'";
                conn.SQLExecuteCmm(_SQLConnection, consulta);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}
