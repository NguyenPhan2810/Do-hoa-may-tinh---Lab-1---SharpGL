using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace Lab1_SharpGL
{
    class Rectangle : Shape
    {
        Point firstPoint;
        Point secondPoint;
        bool isMouseDown;
        public Rectangle()
        {
            isMouseDown = false;
        }

        public override void event_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                secondPoint = e.Location;

                int left = firstPoint.X;
                int right = firstPoint.X;
                int bot = firstPoint.Y;
                int top = firstPoint.Y;


                if (left > secondPoint.X) left = secondPoint.X;
                if (right < secondPoint.X) right = secondPoint.X;
                if (top > secondPoint.Y) top = secondPoint.Y;
                if (bot < secondPoint.Y) bot = secondPoint.Y;

                vPoints[0] = new Point(left, top);
                vPoints[1] = new Point(left, bot);
                vPoints[2] = new Point(right, bot);
                vPoints[3] = new Point(right, top);
            }
        }

        public override void event_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                firstPoint = e.Location;
                vPoints.Add(e.Location);
                vPoints.Add(e.Location);
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
