using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2Progra2Real.Properties;

namespace Tarea2Progra2Real
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int op = 0, cantidad = 0, ordinario = 0, puesto = 0, horaslaboradas, preciohora;
            double bruto1, bruto2, bruto3, deduc1, deduc2, deduc3, porcentaje1, porcentaje2, porcentaje3, neto1, neto2, neto3;
            Clsempleados Ind = new Clsempleados();

            while (op!=3)
            {
                Console.WriteLine("Bienvenido a Distribuidora Los Manzanos");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Ingresar los empleados");
                Console.WriteLine("2.Ingresar datos de los empleados");
                Console.WriteLine("3.Salir");
                Console.WriteLine("Ingrese la opcion deseada");
                op= int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Ind.Ind(cantidad);

                        break;
                    case 2:
                        Ind.Imprimir();
                        Console.WriteLine("Digite el nombre del empleado que desea calcular");
                        Console.ReadLine();
                        Console.WriteLine("Digite la cantidad de horas laboradas");
                        horaslaboradas=int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el precio por hora laborada");
                        preciohora=int.Parse(Console.ReadLine());
                        ordinario=horaslaboradas*preciohora;
                        porcentaje1 = (ordinario*0.15);
                        porcentaje2 = (ordinario*0.10);
                        porcentaje3 = (ordinario*0.05);
                        bruto1 = (ordinario+porcentaje1);
                        bruto2 = (ordinario+porcentaje2);
                        bruto3 = (ordinario+porcentaje3);
                        deduc1 = (bruto1*0.0917);
                        deduc2 = (bruto2*0.0917);
                        deduc3 = (bruto3*0.0917);
                        neto1 = (bruto1-deduc1);
                        neto2 = (bruto2-deduc2);
                        neto3 = (bruto3-deduc3);
                        Console.WriteLine("Horas laboradas "+ horaslaboradas);
                        Console.WriteLine("Precio por hora "+ preciohora);
                        Console.WriteLine("Salario ordinario "+ ordinario);
                        Console.WriteLine("Digite el numero de puesto: ");
                        Console.WriteLine("1.Operario");
                        Console.WriteLine("2.Tecnico");
                        Console.WriteLine("3.Profesional");
                        puesto=int.Parse(Console.ReadLine());

                        if (puesto==1)
                        {
                            Console.WriteLine("Operario");
                            Console.WriteLine("Aumento 15%: "+porcentaje1);
                            Console.WriteLine("Salario bruto " +bruto1);
                            Console.WriteLine("Deduccion CCSS " +deduc1);
                            Console.WriteLine("Salario neto " +neto1);
                        }
                        else
                        if (puesto==2)
                        {
                            Console.WriteLine("Tecnico");
                            Console.WriteLine("El salario aumento un 10% " +porcentaje2);
                            Console.WriteLine("El salario bruto es: " +bruto2);
                            Console.WriteLine("Deduccion CCSS " +deduc2);
                            Console.WriteLine("Salario neto " +neto2);
                        }
                        else
                            if (puesto==3)
                        {
                            Console.WriteLine("Profesional");
                            Console.WriteLine("El salario aumento un 5% " +porcentaje3);
                            Console.WriteLine("El salario bruto es: " +bruto3);
                            Console.WriteLine("Deduccion CCSS " +deduc3);
                            Console.WriteLine("Salario neto " +neto3);
                        }

                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
