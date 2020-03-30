using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp4
{
    public class CN_Colaboradores
    {
        private CD_Colaboradores objetoCD = new CD_Colaboradores();

        public void InsertarColaborador(string ColaboradorID, string Estado, string Hora)
        {

            objetoCD.Insertar(ColaboradorID, Estado, Hora, 0);
        }


    }
}
