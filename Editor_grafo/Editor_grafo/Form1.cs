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

        Arista arisOri;
        Arista arisCopia;

        public Form_Editor()
        {
            InitializeComponent();
        }

        private void Form_Editor_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            vertices = new List<Vertice>();
            aristas = new List<Arista>();
        }

        private void Form_Editor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool band = false;
            Arista aristaSel = null;

            if (e.Button == MouseButtons.Left) // si es el click izquierdo, se agregara un nuevo vertice
            {
                if (vertices.Count != 0)
                {
                  foreach (Vertice v in vertices)
                  {
                        //if (e.X >= v.getX() - radio && e.Y >= v.getY() - radio &&
                        //    e.X <= v.getX() + radio && e.Y <= v.getY() + radio)
                        // {
                        if (v.Adentro(e.Location))
                        {
                            //MessageBox.Show("Esta dentro en el vertice: " + v.getNum());
                            band = true;
                            lb_config.Items.Clear();
                            lb_config.Items.Add("Numero de Nodo: " + v.getNum());
                            bool ban = false;
                            foreach (Arista ar in aristas)
                            {
                                if (v.getNum() == ar.getNumA())
                                {
                                    ban = true;
                                    break;
                                }
                                else
                                {
                                    ban = false;
                                }
                            }
                            if (ban)
                            {
                                lb_config.Items.Add("Grafo dirigido");
                            }
                            else
                            {
                                lb_config.Items.Add("Grafo no dirigido");
                            }
                            break;
                        }
                        //  }
                  }

                  if (!band)
                  {
                     band = false;
                     vertices.Add(new Vertice(e.X, e.Y, radio));
                     Refresh();
                  }
                }
                else
                {
                    vertices.Add(new Vertice(e.X, e.Y, radio));
                    Refresh();
                }
            }
            else if(e.Button == MouseButtons.Right) //si es el derecho se agregara una nueva arista
            {
                foreach (Vertice v in vertices)
                {
                    if (v.Adentro(e.Location))
                    {
                        aristaSel = new Arista(v, radio);
                        aristas.Add(aristaSel);

                        if (arisOri == null)
                        {
                            arisOri = aristaSel;
                        }
                        else
                        {
                            if (aristaSel!= null)
                            {
                                arisOri.ConectarA(aristaSel);
                                //arisOri.ConectarB(vertices);
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
                a.DibujaArista(e.Graphics);
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
                    //if (e.X >= v.getX() - radio && e.Y >= v.getY() - radio &&
                    //    e.X <= v.getX() + radio && e.Y <= v.getY() + radio)
                    //{
                        //selVertice = v;
                        //seleccion = true;
                    //}
                }
            }
        }

        private void Form_Editor_MouseMove(object sender, MouseEventArgs e) //cuando se mueve el mouse
        {
            //if (selVertice == null) return;
            if (seleccion)
            {
               // arisCopia.modificarPosArista(e.Location);
                selVertice.Posicion(e.Location);
                arisCopia.modificarPosArista(e.Location);
                //Refresh();
                Invalidate();
            }
        }

        private void Form_Editor_MouseUp(object sender, MouseEventArgs e) // al soltar el click, se deselecciona el nodo
        {
            seleccion = false;
        }

        public List<Vertice> getListVert()
        {
            return vertices;
        }
    }
}
