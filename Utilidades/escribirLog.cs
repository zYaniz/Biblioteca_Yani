using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestiónBiblioteca_Yani.Utilidades
{
    public class escribirLog
    {
        public static string mensajeLog { get; set; }
        public static Boolean mostrarConsola { get; set; }

        public escribirLog(string mensajeEnviar, Boolean mostrarConsola)
        {
            mensajeLog = mensajeEnviar;
            if (mostrarConsola)
                monstrarMensajeConsola();
            escribirLineaFichero();
        }
        public escribirLog()
        {
            if (mostrarConsola)
                monstrarMensajeConsola();
            escribirLineaFichero();
        }

        public void monstrarMensajeConsola()
        {
            mensajeLog = mensajeLog.Replace(Environment.NewLine, " | ");
            mensajeLog = mensajeLog.Replace("\r\n", " | ").Replace("\n", " | ").Replace("\r", " | ");
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + mensajeLog);
        }
        public void escribirLineaFichero()
        {
            try
            {
                FileStream fs = new FileStream(@AppDomain.CurrentDomain.BaseDirectory +
                    "bitacora.log", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);

                mensajeLog = mensajeLog.Replace(Environment.NewLine, " | ");
                mensajeLog = mensajeLog.Replace("\r\n", " | ").Replace("\n", " | ").Replace("\r", " | ");
                m_streamWriter.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + mensajeLog);
                m_streamWriter.Flush();
                m_streamWriter.Close();
            }
            catch
            {
            }
        }
    }
}
