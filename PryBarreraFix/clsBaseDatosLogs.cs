using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryFernandezIES
{
    internal class clsBaseDatosLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter objDataAdap;
        OleDbDataReader lectorBD;
        DataSet objDataSet = new DataSet();

        public string datosTabla;
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb");
                conexionBD.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        public void TraerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "LOGS";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Fecha", "Fecha");
            grilla.Columns.Add("Detalle", "Detalle");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    // ✅ Acceso por nombre de columna, no por índice
                    datosTabla += "-" + lectorBD["Nombre"];
                    grilla.Rows.Add(lectorBD["Nombre"], lectorBD["Fecha"], lectorBD["Resultado"]);
                }
            }
        }

        public void Logs(string usuario, DateTime fecha, string accion)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "LOGS";

            objDataAdap = new OleDbDataAdapter(comandoBD);

            DataSet dsLocal = new DataSet();
            objDataAdap.Fill(dsLocal, "LOGS");

            DataTable dt = dsLocal.Tables["LOGS"];
            DataRow dr = dt.NewRow();

            dr["Nombre"] = usuario;
            dr["Fecha"] = fecha;
            dr["Resultado"] = accion;
            dt.Rows.Add(dr);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(objDataAdap);
            objDataAdap.Update(dsLocal, "LOGS");

            conexionBD.Close();
            conexionBD.Dispose();
        }
    }
}
