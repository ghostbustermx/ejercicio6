using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Conexion
    {
        private SqlConnection Conection = new SqlConnection("Server=DESKTOP-RNN2PBF\\DEVELOP;DataBase= Practica;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conection.State == ConnectionState.Closed)
                Conection.Open();
            return Conection;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conection.State == ConnectionState.Open)
                Conection.Close();
            return Conection;
        }
    }
}
