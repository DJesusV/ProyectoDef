using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDef
{
    internal class ClsTransacciones
    {
        private const int MaxVehiculos = 5;
        private int[] numeroFactura = new int[MaxVehiculos];
        private string[] numeroPlaca = new string[MaxVehiculos];
        private string[] fecha = new string[MaxVehiculos];
        private string[] hora = new string[MaxVehiculos];
        private int[] tipoVehiculo = new int[MaxVehiculos];
        private int[] numeroCaseta = new int[MaxVehiculos];
        private int[] montoPagar = new int[MaxVehiculos];
        private int[] pagaCon = new int[MaxVehiculos];
        private int[] vuelto = new int[MaxVehiculos];
        private int cantidadVehiculos = 0;

        public void Ingresar()
        {
            Console.WriteLine("Ingrese los siguientes datos");

            Console.WriteLine("Numero de factura: ");
            numeroFactura[cantidadVehiculos] = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de placa: ");
            numeroPlaca[cantidadVehiculos] = Console.ReadLine();

            Console.WriteLine("Fecha: ");
            fecha[cantidadVehiculos] = Console.ReadLine();

            Console.WriteLine("Hora: ");
            hora[cantidadVehiculos] = Console.ReadLine();

            Console.WriteLine("Tipo de vehículo:");
            Console.WriteLine("1. Moto");
            Console.WriteLine("2. Vehiculo Liviano");
            Console.WriteLine("3. Camion o Pesado");
            Console.WriteLine("4. Autobus");
            Console.Write("Seleccione el tipo de vehiculo: ");
            tipoVehiculo[cantidadVehiculos] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNumero caseta:");
            Console.WriteLine("1. Caseta 1");
            Console.WriteLine("2. Caseta 2");
            Console.WriteLine("3. Caseta 3");
            Console.Write("Seleccione el numero de caseta: ");
            numeroCaseta[cantidadVehiculos] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMonto a pagar:");
            Console.WriteLine("Vehiculo liviano: ¢700");
            Console.WriteLine("Camión o Pesado: ¢2700");
            Console.WriteLine("Motocicleta: ¢500");
            Console.WriteLine("Autobus: ¢3700");

            switch (tipoVehiculo[cantidadVehiculos])
            {
                case 1:
                    montoPagar[cantidadVehiculos] = 500;
                    break;
                case 2:
                    montoPagar[cantidadVehiculos] = 700;
                    break;
                case 3:
                    montoPagar[cantidadVehiculos] = 2700;
                    break;
                case 4:
                    montoPagar[cantidadVehiculos] = 3700;
                    break;
                default:
                    Console.WriteLine("Tipo de vehiculo no encontrado.");
                    return;
            }

            Console.Write("Monto a pagar: ");
            int monto = int.Parse(Console.ReadLine());
            if (monto != montoPagar[cantidadVehiculos])
            {
                Console.WriteLine("El monto ingresado no coincide con el monto a pagar.");
                return;
            }

            Console.Write("Paga con: ");
            pagaCon[cantidadVehiculos] = int.Parse(Console.ReadLine());

            vuelto[cantidadVehiculos] = pagaCon[cantidadVehiculos] - montoPagar[cantidadVehiculos];

            cantidadVehiculos++;
            Console.WriteLine("Registro ingresado exitosamente.");
        }

        public void Consulta()
        {
            Console.Write("Ingrese el numero de placa: ");
            string placa = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < cantidadVehiculos; i++)
            {
                if (numeroPlaca[i] == placa)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine("Datos del vehiculo con numero de placa '{0}':", placa);
                Console.WriteLine("Numero Factura: {0}", numeroFactura[indice]);
                Console.WriteLine("Fecha: {0}", fecha[indice]);
                Console.WriteLine("Hora: {0}", hora[indice]);
                Console.WriteLine("Tipo de vehículo: {0}", tipoVehiculo[indice]);
                Console.WriteLine("Numero caseta: {0}", numeroCaseta[indice]);
                Console.WriteLine("Monto a pagar: {0}", montoPagar[indice]);
                Console.WriteLine("Paga con: {0}", pagaCon[indice]);
                Console.WriteLine("Vuelto: {0}", vuelto[indice]);
            }
            else
            {
                Console.WriteLine("No se encontró ningún vehículo con el número de placa '{0}'.", placa);
            }
        }

        public void Modificar()
        {
            Console.Write("Ingrese el numero de placa del vehiculo a modificar: ");
            string placa = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < cantidadVehiculos; i++)
            {
                if (numeroPlaca[i] == placa)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine("\nDatos actuales del vehiculo con numero de placa '{0}':", placa);
                Console.WriteLine("Numero Factura: {0}", numeroFactura[indice]);
                Console.WriteLine("Fecha: {0}", fecha[indice]);
                Console.WriteLine("Hora: {0}", hora[indice]);
                Console.WriteLine("Tipo de vehiculo: {0}", tipoVehiculo[indice]);
                Console.WriteLine("Numero caseta: {0}", numeroCaseta[indice]);
                Console.WriteLine("Monto a pagar: {0}", montoPagar[indice]);
                Console.WriteLine("Paga con: {0}", pagaCon[indice]);
                Console.WriteLine("Vuelto: {0}", vuelto[indice]);

                Console.WriteLine("1. Fecha");
                Console.WriteLine("2. Hora");
                Console.WriteLine("3. Tipo de vehiculo");
                Console.WriteLine("4. Numero caseta");
                Console.WriteLine("5. Monto a pagar");
                Console.WriteLine("6. Paga con");
                Console.WriteLine("7. Vuelto");
                Console.WriteLine("8. Cancelar modificacion");
                Console.Write("Seleccione una opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nueva fecha: ");
                        fecha[indice] = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Nueva hora: ");
                        hora[indice] = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Nuevo tipo de vehiculo:");
                        Console.WriteLine("1. Moto");
                        Console.WriteLine("2. Vehiculo Liviano");
                        Console.WriteLine("3. Camion o Pesado");
                        Console.WriteLine("4. Autobus");
                        Console.Write("Seleccione el nuevo tipo de vehiculo: ");
                        tipoVehiculo[indice] = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Nuevo numero caseta:");
                        Console.WriteLine("1. Caseta 1");
                        Console.WriteLine("2. Caseta 2");
                        Console.WriteLine("3. Caseta 3");
                        Console.Write("Seleccione el nuevo numero de caseta: ");
                        numeroCaseta[indice] = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Nuevo monto a pagar:");
                        Console.WriteLine("Vehiculo liviano: ¢700");
                        Console.WriteLine("Camión o Pesado: ¢2700");
                        Console.WriteLine("Motocicleta: ¢500");
                        Console.WriteLine("Autobús: ¢3700");

                        switch (tipoVehiculo[indice])
                        {
                            case 1:
                                montoPagar[indice] = 500;
                                break;
                            case 2:
                                montoPagar[indice] = 700;
                                break;
                            case 3:
                                montoPagar[indice] = 2700;
                                break;
                            case 4:
                                montoPagar[indice] = 3700;
                                break;
                        }

                        Console.Write("Nuevo monto a pagar: ");
                        int monto = int.Parse(Console.ReadLine());
                        if (monto != montoPagar[indice])
                        {
                            Console.WriteLine("El monto ingresado no coincide con el monto a pagar.");
                            return;
                        }
                        break;
                    case 6:
                        Console.Write("Nuevo paga con: ");
                        pagaCon[indice] = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        vuelto[indice] = pagaCon[indice] - montoPagar[indice];
                        break;
                    case 8:
                        Console.WriteLine("Cancelando modificacion.");
                        return;
                    default:
                        Console.WriteLine("Opción invalida.");
                        return;
                }

                Console.WriteLine("Modificacion realizada exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontro ningun vehiculo con el numero de placa '{0}'.", placa);
            }
        }

        public void Reporte()
        {
            Console.WriteLine("Título del Reporte");
            Console.WriteLine("N factura\tPlaca\t\ttipo de vehiculo\tcaseta\tmonto Pagar\tpaga con\tvuelto");
            Console.WriteLine("===============================================================================");

            for (int i = 0; i < cantidadVehiculos; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t{4}\t\t{5}\t\t{6}",
                    numeroFactura[i], numeroPlaca[i], tipoVehiculo[i], numeroCaseta[i], montoPagar[i], pagaCon[i], vuelto[i]);
            }

            Console.WriteLine("===============================================================================");
            Console.WriteLine("Cantidad de vehiculos: {0}\t\ttotal: {1}", cantidadVehiculos, pagaCon[0]);
            Console.WriteLine("===============================================================================");
            Console.WriteLine("\t\t\t\t\t<<<Pulse tecla para regresar >>>");
            Console.ReadLine();
        }

        public void LimpiarVectores()
        {
            for (int i = 0; i < MaxVehiculos; i++)
            {
                numeroFactura[i] = 0;
                numeroPlaca[i] = "";
                fecha[i] = "";
                hora[i] = "";
                tipoVehiculo[i] = 0;
                numeroCaseta[i] = 0;
                montoPagar[i] = 0;
                pagaCon[i] = 0;
                vuelto[i] = 0;
            }

            cantidadVehiculos = 0;

            Console.WriteLine("Vectores inicializados correctamente.");
        }
    }
}
