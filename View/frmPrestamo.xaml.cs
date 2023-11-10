using SistemaGestiónBiblioteca_Yani.Clases;
using SistemaGestiónBiblioteca_Yani.Dtos;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SistemaGestiónBiblioteca_Yani.View
{
    public partial class frmPrestamo : Window
    {
        public frmPrestamo()
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

        private void btnLibro_Click(object sender, RoutedEventArgs e)
        {
            frmLibro ventana = new frmLibro();
            ventana.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSolicitar_Click(object sender, RoutedEventArgs e)
        {
            txtFechaAdicion.Text = System.DateTime.Now.ToString();
            txtAdicionadoPor.Text = "admin";

            string textoIngresado = txtSolPrestamo.Text.ToLower(); 

            if (textoIngresado != "si" && textoIngresado != "no")
            {
                MessageBox.Show("Por favor, ingrese 'Si' o 'No' en el campo de préstamo.");
                txtSolPrestamo.Text = string.Empty;
            }
            else
            {
                if (textoIngresado == "si")
                {
                    DateTime selectedDate = dtpFechaDevolucion.SelectedDate.GetValueOrDefault();
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaMaxima = fechaActual.AddDays(5);

                    if (selectedDate < fechaActual || selectedDate > fechaMaxima)
                    {
                        MessageBox.Show("Por favor, elija una fecha entre hoy y máximo 5 días.");
                        dtpFechaDevolucion.SelectedDate = null;
                        return; 
                    }
                }

                clsPrestamo prestamo = new clsPrestamo(
                    txtSolLibro.Text,
                    txtSolCedula.Text,
                    txtSolPrestamo.Text,
                    dtpFechaDevolucion.Text,
                    txtAdicionadoPor.Text,
                    txtFechaAdicion.Text);

                dtoPrestamo prebdto = new dtoPrestamo();
                if (prebdto.InsertarPrestamo(prestamo) == true)
                {
                    MessageBox.Show("Solicitud Exitosa");
                }
            }
        }
        private void btnGestion_Click(object sender, RoutedEventArgs e)
        {
            frmGestion ventana = new frmGestion();
            ventana.Show();
            this.Close();
        }

        private void btnDevolucion_Click(object sender, RoutedEventArgs e)
        {
            frmDevolucion ventana = new frmDevolucion();
            ventana.Show();
            this.Close();
        }

    }
}
