using System;

namespace SistemaGestiónBiblioteca_Yani.Clases
{
    public class clsPrestamo
    {

        private string libro;
        private string usuario;
        private string prestamoActivo;
        private string fechaDevolucion;
        private string adicionadoPor;
        private string fechaAdicion;
        public string Libro
        {
            get { return libro; }
            set { libro = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string PrestamoActivo
        {
            get { return prestamoActivo; }
            set { prestamoActivo = value; }
        }

        public string FechaDevolucion
        {
            get { return fechaDevolucion; }
            set { fechaDevolucion = value; }
        }

        public string AdicionadoPor
        {
            get { return adicionadoPor; }
            set { adicionadoPor = value; }
        }

        public string FechaAdicion
        {
            get { return fechaAdicion; }
            set { fechaAdicion = value; }
        }

        public clsPrestamo()
        {

        }
        public clsPrestamo(string lib, string usu, string pre, string fdev,
               string adi, string fad)
        {
            this.libro = lib;
            this.usuario = usu;
            this.prestamoActivo = pre;
            this.fechaDevolucion = fdev;
            this.adicionadoPor = adi;
            this.fechaAdicion = fad;
        }
    }
}
