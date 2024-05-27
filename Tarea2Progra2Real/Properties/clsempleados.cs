using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Progra2Real.Properties
{
    internal class Clsempleados
    {
        string[] empleados1;
        int cedula;
        
        public void Ind(int cantidadempleados)
        {
            Console.WriteLine("Ingrese la cantidad de empleados");
            cantidadempleados = int.Parse(Console.ReadLine());
            empleados1 = new string[cantidadempleados];
            for (int i = 0; i<empleados1.Length; i++)
            {

                Console.WriteLine("Ingrese el nombre del empleado "+(i+1));
                empleados1[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de cedula");
                cedula = int.Parse(Console.ReadLine());
                
            }
        }

        public void Imprimir()
        {

            Console.WriteLine("Los nombres de los empleados son: ");
            for (int i = 0; i < empleados1.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + empleados1[i].ToString());
                Console.WriteLine("Cedula "+ cedula);
               
            }
        }
    }
}

    

