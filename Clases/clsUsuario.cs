namespace SistemaGestiónBiblioteca_Yani.Clases
{
    public class clsUsuario
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string direccion;
        private string correo;
        private string adicionadoPor;
        private string fechaAdicion;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
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

        public clsUsuario()
        {

        }
        public clsUsuario(string nom, string ape, string ced, string dir,
            string cor, string adi, string fad)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.cedula = ced;
            this.direccion = dir;
            this.correo = cor;
            this.adicionadoPor = adi;
            this.fechaAdicion = fad;
        }
    }
}
