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

            if (e.Button == MouseButtons.Left) // si es el click izquierdo, se agregara un nuevo vertice
            {
                if (vertices.Count != 0)
                {
                  foreach (Vertice v in vertices)
                  {
                     if (e.X >= v.getX() - radio && e.Y >= v.getY() - radio &&
                         e.X <= v.getX() + radio && e.Y <= v.getY() + radio)
                     {
                            MessageBox.Show("Esta dentro en el vertice: " + v.getNum());
                            band = true;
                        break;
                     }
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
            else //si es el derecho se agregara una nueva arista
            {
            }
        }

        //se dibuja los nodos
        private void Form_Editor_Paint(object sender, PaintEventArgs e)
        {
            foreach (Vertice v in vertices)
            {
                v.DibujaVertice(e.Graphics);
            }
        }

        private void Form_Editor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // si es el click izquierdo, se agregara un nuevo vertice
            {
                foreach (Vertice v in vertices)
                {
                    if (e.X >= v.getX() - radio && e.Y >= v.getY() - radio &&
                        e.X <= v.getX() + radio && e.Y <= v.getY() + radio)
                    {
                        selVertice = v;
                        seleccion = true;
                        break;
                    }
                }
            }
        }

        private void Form_Editor_MouseMove(object sender, MouseEventArgs e) //cuando se mueve el mouse
        {
            if (selVertice == null) return;
            if (seleccion)
            {
                selVertice.Posicion(e.Location);
                Refresh();
                Invalidate();
            }
        }

        private void Form_Editor_MouseUp(object sender, MouseEventArgs e) // al soltar el click, se deselecciona el nodo
        {
            seleccion = false;
        }
    }
}
