using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;

namespace LibreriaPixie
{
    public class PixieDust
    {
        public PixieDust()
        {

        }
        
        public void picPaint(int x, int y, int sX, int sY, int cX, int cY, int index, Pen p, Graphics g)
        {
            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        public void picMouseUp(int x, int y, int sX, int sY, int cX, int cY, int index, Pen p, Graphics g)
        {
            
            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        public void TamLapices(Pen p, RadioButton rbt1, RadioButton rbt2, RadioButton rbt5, RadioButton rbt10)
        {
            if (rbt1.Checked)
            {
                p.Width = 1;
            }

            else if (rbt2.Checked)
            {
                p.Width = 2;
            }
            else if (rbt5.Checked)
            {
                p.Width = 5;
            }
            else if (rbt10.Checked)
            {
                p.Width = 10;
            }
        }
    }
}
