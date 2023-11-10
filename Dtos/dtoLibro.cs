using SistemaGestiónBiblioteca_Yani.BaseDatos;
using SistemaGestiónBiblioteca_Yani.Clases;
using System;
using System.Windows;

namespace SistemaGestiónBiblioteca_Yani.Dtos
{
    public class dtoLibro
    {
        private ConnSQL conn = new ConnSQL();
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool insertarLibro(clsLibro libro)
        {
            try
            {
                string consulta = "EXEC InsertarLibro " +
                    "'" + libro.Titulo + "'," +
                    "'" + libro.Autor + "'," +
                    "'" + libro.ISBN+"'," +
                    "'"+libro.Categoria+"'," +
                    "'"+libro.Disponibilidad+"'," +
                    "'"+libro.AdicionadoPor+"'";
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
