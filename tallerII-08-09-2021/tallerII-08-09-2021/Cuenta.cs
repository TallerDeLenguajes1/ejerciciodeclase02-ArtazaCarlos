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
        private int monto;
        private static List<Extracion> extraciones = new List<Extracion>();

        protected int Monto { get => monto; set => monto = value; }
        

        public Cuenta()
        {

        }
        public Cuenta(int monto)
        {
            Monto = monto;
        }

        public void ingresoDinero(int ingreso)
        {
            Monto += ingreso;
        }

        public void extraccionCajeroHumano(string tipo, int extracion)
        {
            if (tipo == TipoDeExtracion.cajeroHumano.ToString())
            {
                if (Monto >= 0)
                {
                    Monto -= extracion;
                }
                
            }
        }

        public virtual void extraccionCajeroAutomatico(string tipo, int extracion)
        {
            if (tipo == TipoDeExtracion.cajeroHumano.ToString())
            {
                
            }
        }
    }
    public class CuentaAhorro : Cuenta
    {
        
        public override void extraccionCajeroAutomatico(string tipo, int extracion)
        {
            if (tipo == TipoDeExtracion.cajeroAutomatico.ToString())
            {
                
            }
        }
    }

    public class CuentaCorriente : Cuenta
    {

        public override void extraccionCajeroAutomatico(string tipo, int extracion)
        {
            if (tipo == TipoDeExtracion.cajeroAutomatico.ToString())
            {
                if ((Monto - extracion) >= -5000)
                {
                    Monto -= extracion;  
                }
                
            }
        }
    }

    public class CuentaCorrienteDolares : Cuenta
    {

        public override void extraccionCajeroAutomatico(string tipo, int extracion)
        {
            if (tipo == TipoDeExtracion.cajeroAutomatico.ToString())
            {

            }
        }
    }
}
