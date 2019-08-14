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
        int x, y, radio; //pos del vertice
        List<Arista> conector;
        Point centro;

        public Arista(int x, int y, int radio)
        {
            centro = new Point(x, y);
            this.radio = radio;

        }

        public void DibujaArista(Graphics g)
        {
            foreach (Arista item in conector)
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

    }
}
