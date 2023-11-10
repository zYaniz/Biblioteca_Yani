using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestiónBiblioteca_Yani.Clases
{
    public class clsLibro
    {
        private string titulo;
        private string autor;
        private string isbn;
        private string categoria;
        private string disponibilidad;
        private string adicionadoPor;
        private string fechaAdicion;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
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

        public clsLibro()
        {

        }
        public clsLibro(string tit, string aut, string isb, string cat,
            string dis, string adi, string fad)
        {
            this.titulo = tit;
            this.autor = aut;
            this.isbn = isb;
            this.categoria = cat;
            this.disponibilidad = dis;
            this.adicionadoPor = adi;
            this.fechaAdicion = fad;
        }
    }
}
