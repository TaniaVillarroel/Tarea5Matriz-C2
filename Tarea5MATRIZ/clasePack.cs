using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5MATRIZ
{
    class clasePack : ClaseProductoEjercicio5
    {
        int unidades;

        public int pUnidades
        {
            set {unidades = value;}
            get {return unidades;}
        }

        public clasePack() : base()
        {
            unidades = 0 ;
        }

        public override double calcularImporte()
        {
            return unidades * pPrecio;
        }

        public override string toString()
        {
            return "Pack: " + unidades + base.toString();
        }
    }
}
