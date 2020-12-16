using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5MATRIZ
{
    public partial class formPolimorfismo2 : Form
    {
        const int tam = 3;

        ClaseProductoEjercicio5[] aProducto = new ClaseProductoEjercicio5[tam]; // hemos definido un arreglo de tipo producto 

        int contador;

        public formPolimorfismo2()
        {
            InitializeComponent(); 

            for (int i = 0; i < tam; i++)
            {
                aProducto[i] = null;
            }

            contador = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (contador == tam)
                MessageBox.Show("Se completo la matriz");
            else
            {
                if (chkPack.Checked)
                {
                    clasePack p = new clasePack();
                    p.pNombre = txtNombre.Text;
                    p.pPrecio = double.Parse(txtPrecio.Text);
                    p.pUnidades = int.Parse(txtCantidad.Text);
                    p.pCantidad = int.Parse(txtCantidad.Text);

                    aProducto[contador] = p;
                    lstNombre.Items.Add(aProducto[contador].pNombre);
                    lstPrecio.Items.Add(aProducto[contador].calcularImporte());
                    lstCantidad.Items.Add(aProducto[contador].pCantidad);

                    contador++;
                }

                else
                {
                    claseSuelto s = new claseSuelto();
                    s.pNombre = txtNombre.Text;
                    s.pPrecio = double.Parse(txtPrecio.Text);
                    s.pMedida = int.Parse(txtCantidad.Text);
                    s.pCantidad = int.Parse(txtCantidad.Text);

                    aProducto[contador] = s;
                    lstNombre.Items.Add(aProducto[contador].pNombre);
                    lstPrecio.Items.Add(aProducto[contador].calcularImporte());
                    lstCantidad.Items.Add(aProducto[contador].pCantidad);
                    
                    contador++;
                }
                


            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double acuTotal=0;
            lstImporte.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                lstImporte.Items.Add(aProducto[i].calcularImporte());
                acuTotal += aProducto[i].calcularImporte();
            }
            txtTotal.Text= acuTotal.ToString();
        }
       
    }
}
