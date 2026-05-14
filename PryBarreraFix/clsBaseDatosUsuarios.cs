using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Data;

namespace pryFernandezIES
{
    class clsBaseDatosUsuarios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        // ✅ Contador de intentos fallidos (instancia, está bien aquí)
        int varContador = 0;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data Source=..\..\BaseDeDatos\EL_CLUB.accdb");
                conexionBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        public string datosTabla;

        public void TraerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("Id", "Id");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Contraseña", "Contraseña");
            grilla.Columns.Add("Categoria", "Categoria");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3]);
                }
            }
        }

        public void Login(string usuario, string contraseña, frmInicioSesion frmInicio)
        {
            // ✅ Siempre abre una conexión fresca para cada intento
            ConectarBD();

            // ✅ Verificar que la conexión esté abierta antes de continuar
            if (conexionBD == null || conexionBD.State != ConnectionState.Open)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                return;
            }

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            lectorBD = comandoBD.ExecuteReader();

            // ✅ Variable LOCAL, no de instancia — se resetea en cada llamada
            bool encontro = false;

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    // ✅ Trim() por si hay espacios en la BD
                    string nombreBD = lectorBD[1].ToString().Trim();
                    string passBD = lectorBD[2].ToString().Trim();

                    if (nombreBD == usuario.Trim() && passBD == contraseña.Trim())
                    {
                        string categoria = lectorBD[3].ToString();
                        encontro = true;

                        // Cerrar lectura antes de abrir otra conexión en Logs
                        lectorBD.Close();
                        conexionBD.Close();
                        conexionBD.Dispose();

                        // Registrar log
                        clsBaseDatosLogs objLogs = new clsBaseDatosLogs();
                        objLogs.Logs(usuario, DateTime.Now, "Inicio de Sesion");

                        frmInicio.Hide();
                        frmCargaPrograma cargar = new frmCargaPrograma(usuario, categoria);
                        cargar.Show();
                        break;
                    }
                }
            }

            if (!encontro)
            {
                // Cerrar conexión del intento fallido
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                    conexionBD.Dispose();
                }

                varContador++;
                MessageBox.Show("Datos de inicio de sesión incorrectos.");

                if (varContador >= 3)
                {
                    MessageBox.Show("Demasiados intentos. El sistema se cerrará.");
                    Application.Exit();
                }
            }
        }

        public void registrar(string usuario, string contraseña, string categoria)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            adaptadorBD = new OleDbDataAdapter(comandoBD);

            // ✅ DataSet local para evitar acumulación
            DataSet dsLocal = new DataSet();
            adaptadorBD.Fill(dsLocal, "USUARIOS");

            DataTable dt = dsLocal.Tables["USUARIOS"];
            DataRow dr = dt.NewRow();

            dr["Nombre"] = usuario;
            dr["Contraseña"] = contraseña;
            dr["Categoria"] = categoria;

            dt.Rows.Add(dr);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);
            adaptadorBD.Update(dsLocal, "USUARIOS");

            conexionBD.Close();
            conexionBD.Dispose();
        }
    }
}

