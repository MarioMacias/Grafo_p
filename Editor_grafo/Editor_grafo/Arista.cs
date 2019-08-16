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
        Pen lin;
        int numA;
        Label pesoArista;

        public Arista(Vertice v, int radio)
        {
            centro = new Point(v.getX(), v.getY());
            this.radio = radio;
            numA = v.getNum();
            pesoArista = new Label();

            conec = new List<Arista>();
            lin = new Pen(Brushes.DimGray, 3);
            //Estas son las lineas de la flecha
            gpLin = new GraphicsPath();
            gpLin.AddLine(new Point(0, 0), new Point(3, -3));
            gpLin.AddLine(new Point(0, 0), new Point(-3, -3));
            lin.CustomEndCap = new CustomLineCap(null, gpLin);
            
        }
        
        public void DibujaArista(Graphics g)
        {
            foreach (Arista item in conec)
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

                Point p = new Point(item.centro.X + a, item.centro.Y - b);
                g.DrawLine(lin, centro, p);
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
    }
}
