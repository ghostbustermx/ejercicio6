using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp4
{
    public class CD_Colaboradores
    {
        private Conexion conexion = new Conexion();

   
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();

        public void Insertar(string ColaboradorID, string Estado, string Hora, int TiempoEnEstado)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insert into RegistrosdeEstadoTemp values('" + ColaboradorID + "', '" + Estado + "', '" + Hora + "', 0)";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();


            }
            catch (Exception e)
            {

                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }

            

        }

    }
}
