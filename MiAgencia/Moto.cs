using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAgencia
{
    class Moto : Vehiculo
    {
        #region Atributos
        private bool casco;
        #endregion

        public Moto()
        {
            casco = false;
        }

        public Moto(bool casco)
        {
            this.casco = casco;
        }

        public Moto(int num)
        {
            casco = num == 1 ? true : false;
        }

        public bool Casco { get; set; }
    }
}
