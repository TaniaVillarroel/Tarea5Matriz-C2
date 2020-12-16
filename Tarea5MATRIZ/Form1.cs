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
    public partial class Form1 : Form
    {
      //  int contador = 0;
       int contFila = 0;
       int contcolum = 0;

        const int fil = 2;
        const int colum = 3;
       // const int tam = 2;
        //string[] aNombre = new string[tam];
        //double[] aPrecio = new double[tam];
        //int[] aCantidad = new int [tam];
        //double[] aImporte = new double [tam];
        //En ves de hacer un arreglo para cada atributo hacemos un arreglo producto

       // ClaseProductoEjercicio5[] aProducto = new ClaseProductoEjercicio5[tam];

        // ARREGLO DE DOS DIMENSIONES
        ClaseProductoEjercicio5[,] mProducto = new ClaseProductoEjercicio5 [fil,colum]; //  relacion fila columna 

        public Form1() // esto el profe lo llama contructor
        {
            InitializeComponent();
           // for (int i = 0; i < tam; i++)
            //{
                //aNombre[i] = "";
                //aNombre[i] = string.Empty; // representa la cadena vacia
                //aPrecio[i] = aImporte[i] = aCantidad[i] = 0;

                //aProducto[i] = null; 
          //  }

            for (int f = 0; f < fil; f++)
                for (int c = 0; c < colum; c++)
                    mProducto[f, c] = null;            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aNombre[0] = "pan";
            //aPrecio[0] = 50;
            //aCantidad[0] = 2;

            //aNombre[1] = "leche";
            //aPrecio[1] = 35;
            //aCantidad[1] = 2;

            //for (int i = 0; i < tam; i++)
            //{
            //    lstNombre.Items.Add(aNombre[i]);
            //    lstPrecio.Items.Add(aPrecio[i]);
            //    lstCantidad.Items.Add(aCantidad[i]);
            //}


        }

    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere salir..?",
                               "SALIENDO", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere salir..?",
                                 "SALIENDO", MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Close();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double acumulador = 0;

            lstImporte.Items.Clear();
            //for (int i = 0; i < contador; i++)
            //{
            //    //aImporte[i] = aPrecio[i] * aCantidad[i];
            //    //lstImporte.Items.Add(aImporte[i].ToString());
            //    //acumulador+= aImporte[i];
            //    lstImporte.Items.Add(aProducto[i].calcularImporte());
            //    acumulador += aProducto[i].calcularImporte();
            //}

            for (int f = 0; f < contFila; f++)
                for (int c = 0; c < contcolum; c++)
                {
                    lstImporte.Items.Add(mProducto[f,c].calcularImporte());
                    acumulador += mProducto[f, c].calcularImporte();
                }

            txtImporte.Text = acumulador.ToString(); // esto es un acumulador
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            //if (contador == tam)
            //{
            //    MessageBox.Show("Se completo la carga");
            //    btnCargar.Enabled = false;
            //}
            //else
            //    //{
            //    //    aNombre[contador] = txtNombre.Text;
            //    //    aPrecio[contador] = double.Parse(txtPrecio.Text);
            //    //    aCantidad[contador] = int.Parse(txtCantidad.Text);

            //    //    lstNombre.Items.Add(aNombre[contador]);
            //    //    lstPrecio.Items.Add(aPrecio[contador]);
            //    //    lstCantidad.Items.Add(aCantidad[contador]);

            //    aProducto[contador] = new ClaseProductoEjercicio5();
            //aProducto[contador].pNombre = txtNombre.Text;
            //aProducto[contador].pPrecio = Convert.ToDouble(txtPrecio.Text);
            //aProducto[contador].pCantidad = Convert.ToInt32(txtCantidad.Text);

            //lstNombre.Items.Add(aProducto[contador].pNombre);
            //lstPrecio.Items.Add(aProducto[contador].pPrecio);
            //lstCantidad.Items.Add(aProducto[contador].pCantidad);

            //contador++;

          //  mProducto[contFila, contcolum] = new ClaseProductoEjercicio5(); // habilitar lo desactive para hacer el numero form de poliformisfo
            mProducto[contFila, contcolum].pNombre = txtNombre.Text;
            mProducto[contFila, contcolum].pPrecio = Convert.ToDouble(txtPrecio.Text);
            mProducto[contFila, contcolum].pCantidad = Convert.ToInt32(txtCantidad.Text);

            lstNombre.Items.Add(mProducto[contFila, contcolum].pNombre);
            lstPrecio.Items.Add(mProducto[contFila, contcolum].pPrecio);
            lstCantidad.Items.Add(mProducto[contFila, contcolum].pCantidad);

            contcolum++;

            if (contcolum == colum)
            {
                MessageBox.Show("se completo la fila..." + contFila + 1);
                contFila++;
                contcolum = 0;
            }
            if (contFila == fil)
            {
                MessageBox.Show("se completo la matriz.");
                btnCargar.Enabled = false;
            }
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            double totsuc;

            for (int f = 0; f < fil; f++)
            {
                totsuc = 0;
                for (int c = 0; c < colum; c++)
                {
                    totsuc+= mProducto[f,c].calcularImporte();
                }
                lstSucursal.Items.Add("total sucursal" + (f+1) + totsuc );
            }

        }

        private void btnDia_Click(object sender, EventArgs e)
        {
          double totcolum;
            for (int c = 0; c < colum; c++)
            {
                totcolum = 0;
                for (int f = 0; f < fil; f++)
                {
                    totcolum += mProducto[f, c].calcularImporte();
                }
                lstDia.Items.Add("el total del dia es" + totcolum);
            }
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("¿Quiere salir..?",
        //                       "SALIENDO", MessageBoxButtons.YesNo,
        //                        MessageBoxIcon.Question,
        //                       MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //        e.Cancel = false;
        //    else
        //        e.Cancel = true;
        //}
    }
}
