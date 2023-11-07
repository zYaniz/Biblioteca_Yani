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
    /// Lógica de interacción para frmUsuario.xaml
    /// </summary>
    public partial class frmUsuario : Window
    {
        public frmUsuario()
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
    }
}
