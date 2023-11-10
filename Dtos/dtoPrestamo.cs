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
    public class dtoPrestamo
    {
        private ConnSQL conn = new ConnSQL();
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool InsertarPrestamo(clsPrestamo prestamo)
        {
            try
            {
                string consulta = "EXEC InsertarPrestamo  " +
                    "'" + prestamo.Libro + "'," +
                    "'" + prestamo.Usuario + "'," +
                    "'" + prestamo.PrestamoActivo + "'," +
                    "'" + prestamo.FechaDevolucion + "'," +
                    "'" + prestamo.AdicionadoPor + "'";
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
