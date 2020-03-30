using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            CN_Colaboradores objetoCN = new CN_Colaboradores();

            string path = @"c:\data3.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                var rs = JsonConvert.DeserializeObject<Resultado>(json);


                foreach (var empleado in rs.colaboradores) {
                    Console.WriteLine("   ColaboradorID: " + empleado.ColaboradorID);
                    Console.WriteLine("    Estado: " + empleado.Estado[0]);
                    Console.WriteLine("   Hora del estado:" + empleado.Estado[1]);
                    try
                    {

                        ////////////DateTime[] tiempos = new DateTime[12];

                        ////////////for (int i = 0; i < 12; i++) {
                            
                        ////////////    tiempos[i] = DateTime.Parse(empleado.Estado[1]);
                        ////////////   Console.WriteLine("   Tiempos array: {0}", tiempos[i]);
                        ////////////}


                        //// creating object of DateTime 
                        //DateTime date1 = new DateTime(2011, 1,
                        //                        1, 4, 0, 15);

                        //// creating object of DateTime 
                        //DateTime date2 = new DateTime(2010, 1,
                        //                        1, 4, 0, 15);

                        //// getting ShortTime from DateTime 
                        // using Subtract() method; 
                        //TimeSpan value = date1.Subtract(date2);

                        //// Display the TimeSpan 
                        //Console.WriteLine("TimeSpan between date1" +
                        //" and date2 is {0}", value);

                        objetoCN.InsertarColaborador(empleado.ColaboradorID, empleado.Estado[0], empleado.Estado[1]);
                        //objetoCN.InsertarColaborador(empleado.ColaboradorID, empleado.Estado[0], DateTime.Parse(empleado.Estado[1]));
                    }
                    catch (Exception e)
                    {

                        Console.Write("Exception Thrown: ");
                        Console.Write("{0}", e.GetType(), e.Message);
                    }
                    
                   
                }
                
                Console.ReadLine();
            }
        }
    }
}
