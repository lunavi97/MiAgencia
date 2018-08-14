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

    public class Vehiculo
    {
        #region Atributos
        int id;
        int llantas;
        string modelo;
        int anio;
        ColorVehiculo color;
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
    }
}
