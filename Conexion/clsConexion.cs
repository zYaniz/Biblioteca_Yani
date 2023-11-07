using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace SistemaGestiónBiblioteca_Yani.Conexion
{
    public class clsConexion
    {
        public SqlConnection Connect = new SqlConnection(@"DESKTOP-OVPKNMR\UNIVERSIDAD;Database=BD_BibliotecaYSF;Trusted_Connection=True");
        public DataTable T_Usuario()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarUsuario";
            cmd.Connection = Connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable T_Libro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarLibro";
            cmd.Connection = Connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable T_Prestamo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarPrestamo";
            cmd.Connection = Connect;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void InsertarLibro(string titulo, string autor, string ISBN, string categoria, bool disponibilidad, string usuarioAuditoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] p = new SqlParameter[6];
                p[0] = new SqlParameter("@titulo", SqlDbType.VarChar);
                p[0].Value = titulo;
                p[1] = new SqlParameter("@autor", SqlDbType.VarChar);
                p[1].Value = autor;
                p[2] = new SqlParameter("@ISBN", SqlDbType.VarChar);
                p[2].Value = ISBN;
                p[3] = new SqlParameter("@categoria", SqlDbType.VarChar);
                p[3].Value = categoria;
                p[4] = new SqlParameter("@disponibilidad", SqlDbType.Bit);
                p[4].Value = disponibilidad;
                p[5] = new SqlParameter("@usuarioAuditoria", SqlDbType.VarChar);
                p[5].Value = usuarioAuditoria;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarLibro";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(p);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                MessageBox.Show("Libro registrado");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
            }
        }
        public void InsertarPrestamo(int idLibro, int idUsuario, bool prestamoActivo, DateTime fechaDevolucion, string usuarioAuditoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] p = new SqlParameter[5];
                p[0] = new SqlParameter("@idLibro", SqlDbType.Int);
                p[0].Value = idLibro;
                p[1] = new SqlParameter("@idUsuario", SqlDbType.Int);
                p[1].Value = idUsuario;
                p[2] = new SqlParameter("@prestamoActivo", SqlDbType.Bit);
                p[2].Value = prestamoActivo;
                p[3] = new SqlParameter("@fechaDevolucion", SqlDbType.DateTime);
                p[3].Value = fechaDevolucion;
                p[4] = new SqlParameter("@usuarioAuditoria", SqlDbType.VarChar);
                p[4].Value = usuarioAuditoria;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarPrestamo";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(p);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                MessageBox.Show("Préstamo registrado");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
            }
        }
        public void InsertarUsuario(string nombre, string apellido, string cedula, string direccion, string correo, string usuarioAuditoria)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] p = new SqlParameter[6];
                p[0] = new SqlParameter("@nombre", SqlDbType.VarChar);
                p[0].Value = nombre;
                p[1] = new SqlParameter("@apellido", SqlDbType.VarChar);
                p[1].Value = apellido;
                p[2] = new SqlParameter("@cedula", SqlDbType.VarChar);
                p[2].Value = cedula;
                p[3] = new SqlParameter("@direccion", SqlDbType.VarChar);
                p[3].Value = direccion;
                p[4] = new SqlParameter("@correo", SqlDbType.VarChar);
                p[4].Value = correo;
                p[5] = new SqlParameter("@usuarioAuditoria", SqlDbType.VarChar);
                p[5].Value = usuarioAuditoria;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarUsuario";
                cmd.Connection = Connect;
                cmd.Parameters.AddRange(p);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                MessageBox.Show("Usuario registrado");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar");
            }
        }
    }
}
