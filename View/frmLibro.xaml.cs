using SistemaGestiónBiblioteca_Yani.Clases;
using SistemaGestiónBiblioteca_Yani.Dtos;
using System.Windows;

namespace SistemaGestiónBiblioteca_Yani.View
{
    public partial class frmLibro : Window
    {

        public frmLibro()
        {
            InitializeComponent();
        }
        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmUsuario ventana = new frmUsuario();
            ventana.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            frmInicio ventana = new frmInicio();
            ventana.Show();
            this.Close();
        }

        private void btnPrestamo_Click(object sender, RoutedEventArgs e)
        {
            frmPrestamo ventana = new frmPrestamo();
            ventana.Show();
            this.Close();

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            txtFechaAdicion.Text = System.DateTime.Now.ToString();
            txtAdicionadoPor.Text = "admin";
            clsLibro libro = new clsLibro(txtTitulo.Text, txtAutor.Text, txtISBN.Text, 
                txtCategoria.Text,txtDisponibilidad.Text ,
                txtAdicionadoPor.Text, txtFechaAdicion.Text);

            dtoLibro libdto = new dtoLibro();
            if(libdto.insertarLibro(libro)== true)
            {
                MessageBox.Show("Registro Exitoso");
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            frmBuscarLibro ventana = new frmBuscarLibro();
            ventana.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtDisponibilidad.Text = string.Empty;
        }
    }
}
