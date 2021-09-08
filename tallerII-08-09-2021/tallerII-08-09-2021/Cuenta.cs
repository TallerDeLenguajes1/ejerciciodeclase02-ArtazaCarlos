using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerII_08_09_2021
{
    enum TipoDeExtracion
    {
        cajeroHumano,
        cajeroAutomatico
    }
    public class Cuenta
    {
        protected int monto;

        public int Monto { get => monto; set => monto = value; }

        public Cuenta()
        {

        }
        public Cuenta(int monto)
        {
            Monto = monto;
        }

        public void extraccionCajeroHumano(string tipo, int cantidad)
        {
            if (tipo == TipoDeExtracion.cajeroHumano.ToString())
            {
                Monto = Monto - cantidad;
            }
        }

        public virtual void extraccionCajeroAutomatico(string tipo, int cantidad)
        {
            if (tipo == TipoDeExtracion.cajeroHumano.ToString())
            {
                
            }
        }
    }
    public class CuentaAhorro : Cuenta
    {
        
        public override void extraccionCajeroAutomatico(string tipo, int cantidad)
        {
            if (tipo == TipoDeExtracion.cajeroAutomatico.ToString())
            {
                
            }
        }
    }

    public class CuentaCorriente : Cuenta
    {

        public override void extraccionCajeroAutomatico(string tipo, int cantidad)
        {
            if (tipo == TipoDeExtracion.cajeroAutomatico.ToString())
            {
                
            }
        }
    }
}
