using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Automovil : Vehiculo
    {
        #region Atributos
        private int puertas;
        #endregion

        public Automovil()
        {
            puertas = 4;
        }

        public Automovil(int puertas)
        {
            this.puertas = puertas;
        }

        public int Puertas { get; set; }
    }
}
