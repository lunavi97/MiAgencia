using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    public enum ColorVehiculo
    {
        Ninguno,
        Blanco,
        Gris,
        Rojo,
        Vino,
        Azul,
        Negro        
    };

    public enum Estatus
    {
        Existencia,
        Vendido,
        Entregado
    };

    public class Vehiculo
    {
        #region Atributos
        private int id;
        private int llantas;
        private string modelo;
        private int anio;
        private ColorVehiculo color;
        private Estatus estatus;
        #endregion

        #region Métodos
        public string Capturar()
        {
            // Capturar en BD
            return "Capturado";
        }

        public string Vender()
        {
            // Registrar la venta en BD
            return "Vendido";
        }
        #endregion

        public Vehiculo()
        {
            id = 0;
            modelo = "";
            anio = 2018;
            llantas = 4;
            color = ColorVehiculo.Ninguno;
            estatus = Estatus.Existencia;
        }

        public int Id
        {
            get
            {
                return id;
            }
            
            set
            {
                id = value;
            }
        }

        public string Modelo { get; set; }

        public int Anio { get; set; }

        public int Llantas { get; set; }

        public ColorVehiculo Color { get; set; }
    }
}
