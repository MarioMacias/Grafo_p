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
    public class Vertice
    {
        static int orden = 0;

        int x, y, radio;
        Pen circ;
        int num;
        GraphicsPath gp;
        Font letra;
        Rectangle rec;
        public Point centro;

        public Vertice(int x, int y, int radio)
        {
            this.x = x;     //posición del ratón en x
            this.y = y;     //posición del ratón en y
            this.radio = radio;
            rec = new Rectangle(x - radio, y - radio, 2 * radio, 2 * radio);
            num = ++orden;

            circ = new Pen(Brushes.Black, 3);
            gp = new GraphicsPath();
            gp.AddEllipse(rec);
            letra = new Font("arial", 12);
            centro = new Point(x, y);
        }

        public void DibujaVertice(Graphics g)
        {
            g.FillPath(Brushes.BurlyWood, gp);
            g.DrawPath(circ, gp);
            g.DrawString(num.ToString(), letra, Brushes.Black, rec, 
               new StringFormat() {
                   Alignment = StringAlignment.Center,
                   LineAlignment = StringAlignment.Center});
        }
        
        public void Posicion(Point pt)
        {
            gp.Transform(new Matrix(1, 0, 0, 1, pt.X - centro.X, pt.Y - centro.Y));
            centro = pt;
            rec = Rectangle.Round(gp.GetBounds());
        }

        public bool Adentro(Point pt)
        {
            return gp.IsVisible(pt);
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public int getNum()
        {
            return this.num;
        }
    }
}
