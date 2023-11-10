using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaGestiónBiblioteca_Yani.View
{
    /// <summary>
    /// Lógica de interacción para frmActualizarUsuario.xaml
    /// </summary>
    public partial class frmActualizarUsuario : Window
    {
        public frmActualizarUsuario()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            frmInicio ventana = new frmInicio();
            ventana.Show();
            this.Close();
        }

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            frmLibro ventana = new frmLibro();
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

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            frmUsuario ventana = new frmUsuario();
            ventana.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            frmEliminarUsuario ventana = new frmEliminarUsuario();
            ventana.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
