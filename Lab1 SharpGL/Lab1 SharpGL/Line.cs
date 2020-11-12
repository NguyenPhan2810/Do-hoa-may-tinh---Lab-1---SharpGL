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
        Point start;
        Point end;

        public Line()
        {
            vColors.Add(Color.FromArgb(255, 255, 255));
        }

        public override void event_MouseMove(object sender, MouseEventArgs e)
        {
            end.X = e.Location.X;
            end.Y = e.Location.Y;
        }

        public override void event_MouseDown(object sender, MouseEventArgs e)
        {
            vPoints.Add(new Point(e.Location.X, e.Location.Y));
            start = vPoints[vPoints.Count - 1];
            vPoints.Add(new Point(e.Location.X + 100, e.Location.Y));
            end = vPoints[vPoints.Count - 1];
        }

        public override void event_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
