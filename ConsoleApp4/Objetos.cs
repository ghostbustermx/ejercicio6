using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Resultado
    {
        public Colaboradore[] colaboradores { get; set; }
    }

    public class Colaboradore
    {
        public string ColaboradorID { get; set; }
        public string[] Estado { get; set; }
    }

}
