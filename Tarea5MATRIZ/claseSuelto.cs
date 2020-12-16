using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5MATRIZ
{
    class claseSuelto : ClaseProductoEjercicio5
    {
        int medida;

        public int pMedida
        {
            set { medida = value;  }
            get { return medida; }
        }

        public claseSuelto(): base ()
        {
            medida = 0;
        }

        public override double calcularImporte()
        {
            return medida * base.pPrecio;
        }

        public override string toString()
        {
            return "Suelto" + medida + base.toString();
        }
    }
}
