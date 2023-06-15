using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDef
{
    internal class ClsMenu
    {
        private ClsTransacciones transacciones = new ClsTransacciones();

        public void Menu()
        {
            string opcion;
            do
            {
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de Vehiculos");
                Console.WriteLine("4. Modificar Datos de Vehiculos");
                Console.WriteLine("5. Reporte de Datos Vehiculares");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": transacciones.LimpiarVectores(); break;
                    case "2": transacciones.Ingresar(); break;
                    case "3": transacciones.Consulta(); break;
                    case "4": transacciones.Modificar(); break;
                    case "5": transacciones.Reporte(); break;
                    default: break;
                }
            } while (opcion != "6");
        }
    }
}
