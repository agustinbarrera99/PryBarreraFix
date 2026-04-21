using System;
using System.Data.OleDb;

namespace PryBarreraFix
{
    public class clsConexionDB
    {
        // Conexión y estado
        private OleDbConnection conexion;
        public string estadoConexion { get; private set; }

        public void conectarBaseDeDatos()
        {
            try
            {
                // Ruta relativa a la carpeta BaseDeDatos dentro del proyecto
                string ruta = AppDomain.CurrentDomain.BaseDirectory
                              + @"BaseDeDatos\EL_CLUB.accdb";

                string cadenaConexion =
                    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};Persist Security Info=False;";

                conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();

                estadoConexion = "✅ Conexión exitosa";
            }
            catch (Exception ex)
            {
                estadoConexion = "❌ Error: " + ex.Message;
            }
        }

        // Método para obtener la conexión desde otros formularios
        public OleDbConnection obtenerConexion()
        {
            return conexion;
        }

        // Cerrar conexión
        public void cerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}