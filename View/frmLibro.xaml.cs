using SistemaGestiónBiblioteca_Yani.Clases;
using SistemaGestiónBiblioteca_Yani.Conexion;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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

        private void lstLibros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
