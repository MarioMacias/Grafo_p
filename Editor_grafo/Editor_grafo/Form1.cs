using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editor_grafo
{
    public partial class Form_Editor : Form
    {
        private int radio = 20;
        private List<Vertice> vertices;
        private List<Arista> aristas;
        bool seleccion;
        Vertice selVertice;
        Arista aristaSel;

        Arista arisOri;
        Arista arisCopia;

        int[,] matrizAD;

        public Form_Editor()
        {
            InitializeComponent();
        }

        private void Form_Editor_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            vertices = new List<Vertice>();
            aristas = new List<Arista>();
            check_nodoDir.Checked = true;
        }

        private void Form_Editor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool band = false;
            aristaSel = null;

            if (e.Button == MouseButtons.Left) // si es el click izquierdo, se ve los datos del nodo
            {
                if (vertices.Count != 0)
                {
                    foreach (Vertice v in vertices)
                  {
                        if (v.Adentro(e.Location))
                        {
                            band = true;
                            lb_config.Items.Clear();
                            lb_config.Items.Add("Numero de Nodo: " + v.getNum());
                            if (v.getDirig() == true)
                            {
                                lb_config.Items.Add("Grafo dirigido");
                            }
                            else
                            {
                                lb_config.Items.Add("Grafo no dirigido");
                            }
                            
                            foreach ( Arista a in aristas)
                            {
                                if (v.getNum() == a.getNumA())
                                {
                                    lb_config.Items.Add("Peso de la arista:" + a.getPeso().Text);
                                }  
                            }
                            break;
                        }
                  }

                  if (!band)
                  {
                     band = false;
                     vertices.Add(new Vertice(e.X, e.Y, radio, check_nodoDir.Checked));    //Se agrega un nuevo nodo
                     Refresh();
                  }
                }
                else
                {
                    vertices.Add(new Vertice(e.X, e.Y, radio, check_nodoDir.Checked));
                    Refresh();
                }
            }
            else if(e.Button == MouseButtons.Right) //si es el derecho se agregara una nueva arista
            {
                foreach (Vertice v in vertices)
                {
                    if (v.Adentro(e.Location))
                    {
                        //Creacion del nuevo label numero de peso
                        Label lab = new Label();
                        lab.Name = "numPeso" + v.getNum();
                        lab.Width = 20;
                        lab.Height = 20;
                        Controls.Add(lab); //Controls para agregar el Label a la forma

                        aristaSel = new Arista(v, radio, lab);

                        aristas.Add(aristaSel);
                        if (arisOri == null) //primer nodo seleccionado
                        {
                            arisOri = aristaSel;
                        }
                        else
                        {
                            if (aristaSel!= null) //segundo nodo
                            {
                                arisOri.ConectarA(aristaSel);
                            }
                            arisOri = null;
                            Refresh();
                        }
                    }
                }
            }
        }

        //se dibuja los nodos
        private void Form_Editor_Paint(object sender, PaintEventArgs e)
        {
            foreach (Vertice v in vertices)
            {
                v.DibujaVertice(e.Graphics);
            }
            
            foreach (Arista a in aristas)
            {
                a.DibujaArista(e.Graphics, aristas);
               // a.dibujaArista2(e.Graphics, vertices);
            }
        }

        private void Form_Editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                foreach (Vertice v in vertices)
                {
                    if (v.Adentro(e.Location))
                    {
                        selVertice = v;
                        seleccion = true;

                        foreach (Arista ar in aristas)
                        {
                            if (selVertice.getNum() == ar.getNumA())
                            {
                                arisCopia = ar;
                            }
                        }
                    }
                }
            }
        }

        private void Form_Editor_MouseMove(object sender, MouseEventArgs e) //cuando se mueve el mouse
        {
            if (seleccion)
            {
                selVertice.Posicion(e.Location);
                if(aristas.Count > 0)
                {
                    arisCopia.modificarPosArista(e.Location);
                }
                Invalidate();
            }
        }

        private void Form_Editor_MouseUp(object sender, MouseEventArgs e) // al soltar el click, se deselecciona el nodo
        {
            seleccion = false;
        }

        private void tb_pesoArista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //si preciono enter
            {
                arisCopia.cambioPeso(tb_pesoArista);
                MessageBox.Show("Se modifico el peso de la arista");
                tb_pesoArista.Clear();
            }
        }

        private void btn_EliminarNodo_Click(object sender, EventArgs e)
        {
            if (selVertice != null)
            {
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar el nodo: " + selVertice.getNum(),
                    "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string nom = "numPeso" + selVertice.getNum();
                    foreach (Label labs in this.Controls.OfType<Label>())
                    {
                        if (labs.Name == nom)
                        {
                            this.Controls.Remove(labs);
                            break;
                        }
                    }
                    MessageBox.Show("vertice: " + selVertice.getNum());
                    MessageBox.Show("arista: " + arisCopia.getNumA());
                    vertices.Remove(selVertice);
                    aristas.Remove(arisCopia);
                    
                }
                Refresh();
                selVertice = null;
            }
        }

        private void btn_matrizAdy_Click(object sender, EventArgs e)
        {
            rtb_datos.Clear();
            matrizAD = new int[vertices.Count, vertices.Count];
            llenaMatriz();
            int i;
            int j;
            /*Aqui se llena la matriz dependiendo de la posicion, se tiene
             que quitar uno porque es el numero del nodo*/
            for (i = 0; i < aristas.Count; i++)
            {
                int a = aristas.ElementAt(i).getNumA() - 1;
                int b = aristas.ElementAt(++i).getNumA() - 1;
                if (check_nodoDir.Enabled == true)
                {
                    matrizAD[a, b] = 1;
                }
                else
                {
                    matrizAD[a, b] = 1;
                    matrizAD[b, a] = 1;
                }
            }
            /*Aqui se muestra la matriz*/
            for (i = 0; i < vertices.Count; i++)
            {
                for (j = 0; j < vertices.Count; j++)
                {
                   rtb_datos.Text += matrizAD[i, j] + " ";
                }
                rtb_datos.Text += System.Environment.NewLine;
            }

        }

        private void llenaMatriz()
        {
            int i, j;
            for (i = 0; i < vertices.Count; i++)
            {
                for (j = 0; j < vertices.Count; j++)
                {
                    matrizAD[i, j] = 0;
                }
            }
        }
    }
}
