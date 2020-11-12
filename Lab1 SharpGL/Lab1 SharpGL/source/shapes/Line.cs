using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace Lab1_SharpGL
{
    class Line : Shape
    {
        bool isMouseDown;

        public Line()
        {
            isMouseDown = false;
        }

        public override void event_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                vPoints[1] = e.Location;
            }
        }

        public override void event_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;

                vPoints.Add(e.Location);
                vPoints.Add(e.Location);
            }
        }

        public override void event_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
