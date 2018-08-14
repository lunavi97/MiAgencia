using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Program
    {
        Vehiculo vehiculo;

        private enum TipoVehiculo { Moto = 1, Automovil, Camioneta };

        static void Main(string[] args)
        {
            Program prog = new Program();

            Console.Title = "MiAgencia";

            int tipo;

            do
            {
                Console.WriteLine("Seleccioná opción de captura");
                Console.WriteLine("" + (int)TipoVehiculo.Moto + ". Moto");
                Console.WriteLine("" + (int)TipoVehiculo.Automovil + ". Auto");
                Console.WriteLine("" + (int)TipoVehiculo.Camioneta + ". Camioneta");
                tipo = int.Parse(Console.ReadLine());
            } while (tipo < (int)TipoVehiculo.Moto || tipo > (int)TipoVehiculo.Camioneta);

            Vehiculo vehiculo = prog.CargarDatos((TipoVehiculo)tipo);

            string resp = vehiculo.Capturar();

            Console.WriteLine("Respuesta: " + resp);

            Console.ReadKey();
        }
        
        /// <summary>Cargar datos de vehículo</summary>
        /// <param name="tipo">Tipo de vehículo</param>
        /// <returns>Vehículo</returns>
        private ref Vehiculo CargarDatos(TipoVehiculo tipo)
        {
            switch (tipo)
            {
                case TipoVehiculo.Moto:
                    vehiculo = new Moto();
                    Moto moto = (Moto)vehiculo;
                    CargarMoto(ref moto);
                    break;

                case TipoVehiculo.Automovil:
                    vehiculo = new Automovil();
                    Automovil automovil = (Automovil)vehiculo;
                    CargarAutomovil(ref automovil);
                    break;

                case TipoVehiculo.Camioneta:
                    vehiculo = new Camioneta();
                    Camioneta camioneta = (Camioneta)vehiculo;
                    CargarCamioneta(ref camioneta);
                    break;

                default:
                    vehiculo = null;
                    break;
            }
            
            return ref vehiculo;
        }

        private void CargarMoto(ref Moto moto)
        {
            Vehiculo vehiculo = moto;
            CargarVehiculo(ref vehiculo);

            Console.WriteLine("Casco (0. No; 1. Si)");
            bool casco = int.Parse(Console.ReadLine()) == 1 ? true : false;

            moto.Casco = casco;
        }

        private void CargarAutomovil(ref Automovil automovil)
        {
            Vehiculo vehiculo = automovil;
            CargarVehiculo(ref vehiculo);

            Console.WriteLine("Puertas");
            int puertas = int.Parse(Console.ReadLine());

            automovil.Puertas = puertas;
        }

        private void CargarCamioneta(ref Camioneta camioneta)
        {
            Vehiculo vehiculo = camioneta;
            CargarVehiculo(ref vehiculo);
        }

        private void CargarVehiculo(ref Vehiculo vehiculo)
        {
            Console.WriteLine("Modelo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Año");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("Llantas");
            int llantas = int.Parse(Console.ReadLine());

            ColorVehiculo color = ObtenerColor();

            vehiculo.Id = 0;
            vehiculo.Modelo = modelo;
            vehiculo.Anio = anio;
            vehiculo.Llantas = llantas;
            vehiculo.Color = color;
        }

        private ColorVehiculo ObtenerColor()
        {
            Console.WriteLine("Color");
            Console.WriteLine("" + (int)ColorVehiculo.Blanco + ". Blanco");
            Console.WriteLine("" + (int)ColorVehiculo.Gris + ". Gris");
            Console.WriteLine("" + (int)ColorVehiculo.Rojo + ". Rojo");
            Console.WriteLine("" + (int)ColorVehiculo.Vino + ". Vino");
            Console.WriteLine("" + (int)ColorVehiculo.Azul + ". Azul");
            Console.WriteLine("" + (int)ColorVehiculo.Negro + ". Negro");
            int num = int.Parse(Console.ReadLine());
            if (num >= (int)ColorVehiculo.Blanco && num <= (int)ColorVehiculo.Negro)
            {
                return (ColorVehiculo)num;
            }

            return ColorVehiculo.Ninguno;
        }
    }
}
