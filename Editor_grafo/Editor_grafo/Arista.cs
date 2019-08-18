using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Editor_grafo
{
    class Arista
    {
        int radio; //pos del vertice
         List<Arista> conec;
        Point centro;
        GraphicsPath gpLin;
        Pen lin, linSola;
        int numA;
        bool nodoDirigido;
        Label pesoArista;

        public Arista(Vertice v, int radio, Label pesoArista)
        {
            centro = new Point(v.getX(), v.getY());
            this.radio = radio;
            numA = v.getNum();
            nodoDirigido = v.getDirig();
           // this.pesoArista = new Label();
            this.pesoArista = pesoArista;
            pesoArista.Text = "0";

            conec = new List<Arista>();
            lin = new Pen(Brushes.DimGray, 3); // linea para nodos dirigidos
            linSola = new Pen(Brushes.DimGray, 3); //linea para nodos no dirigidos
            //Estas son las lineas de la flecha
            gpLin = new GraphicsPath();
            gpLin.AddLine(new Point(0, 0), new Point(3, -3));
            gpLin.AddLine(new Point(0, 0), new Point(-3, -3));
            lin.CustomEndCap = new CustomLineCap(null, gpLin);
        }
        
        public void DibujaArista(Graphics g, List<Arista> lisa)
        {
            foreach (Arista item in conec)
            {   /*Aqui se calcula la circunferencia para poder conectar un nodo a otro*/
                if (numA != item.getNumA())
                {
                    double tg = (double)(centro.Y - item.centro.Y) / (item.centro.X - centro.X);
                    double atg = Math.Atan(tg);

                    int a = (int)(radio * Math.Cos(atg));
                    int b = (int)(radio * Math.Sin(atg));

                    if ((centro.X < item.centro.X))
                    {
                        a *= -1;
                        b *= -1;
                    }

                    Point pfin = new Point(item.centro.X + a, item.centro.Y - b);
                    Point pin = new Point(centro.X - a, centro.Y + b);
                    if (nodoDirigido)
                    {
                        g.DrawLine(lin, pin, pfin);
                    }
                    else
                    {
                        g.DrawLine(linSola, pin, pfin);
                    }
                    pesoArista.Visible = true;
                    pesoArista.Location = new Point((pin.X + pfin.X) / 2 - 20, (pin.Y + pfin.Y) / 2 - 20);
                    break;
                }
            }
        }
        public void dibujaArista2(Graphics g, List<Vertice> lisa)
        {
            foreach (Vertice item in lisa)
            {   /*Aqui se calcula la circunferencia para poder conectar un nodo a otro*/
                if (numA != item.getNum())
                {
                    double tg = (double)(centro.Y - item.centro.Y) / (item.centro.X - centro.X);
                    double atg = Math.Atan(tg);

                    int a = (int)(radio * Math.Cos(atg));
                    int b = (int)(radio * Math.Sin(atg));

                    if ((centro.X < item.centro.X))
                    {
                        a *= -1;
                        b *= -1;
                    }

                    Point pfin = new Point(item.centro.X + a, item.centro.Y - b);
                    Point pin = new Point(centro.X - a, centro.Y + b);
                    if (nodoDirigido)
                    {
                        g.DrawLine(lin, pin, pfin);
                    }
                    else
                    {
                        g.DrawLine(linSola, pin, pfin);
                    }
                    pesoArista.Visible = true;
                    pesoArista.Location = new Point((pin.X + pfin.X) / 2 - 20, (pin.Y + pfin.Y) / 2 - 20);
                }
                else
                {
                    break;
                }
            }
        }

        public void modificarPosArista(Point pt)
        {
            gpLin.Transform(new Matrix(1, 0, 0, 1, pt.X - centro.X, pt.Y - centro.Y));
            centro = pt;
        }

        public void ConectarA(Arista a)
        {
            conec.Add(a);
        }
        public void Desconectar(Arista a)
        {
           conec.Remove(a);
        }
        public int getNumA()
        {
            return numA;
        }
        public void cambioPeso(TextBox peso)
        {
            pesoArista.Text = peso.Text;
        }
        public Label getPeso()
        {
            return pesoArista;
        }
    }
}
