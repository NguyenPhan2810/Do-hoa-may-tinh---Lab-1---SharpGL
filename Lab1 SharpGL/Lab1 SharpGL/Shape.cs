using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace Lab1_SharpGL
{
    public class Shape
    {
        public List<Point>  vPoints;
        public List<Color>  vColors;
        public float        fThickness;

        public Shape()
        {
            vPoints = new List<Point>();
            vColors = new List<Color>();
            fThickness = 1f;
        }

        public virtual void event_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public virtual void event_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public virtual void event_MouseUp(object sender, MouseEventArgs e)
        {

        }

        public virtual void draw(OpenGL gl)
        {
            gl.LineWidth(fThickness);

            gl.Begin(OpenGL.GL_LINES);
            int n = vPoints.Count;

            Point prevPoint = vPoints[n - 1];
            for (int i = 0; i < n; ++i)
            {
                Point point = vPoints[i];
                Color color;
                if (vColors.Count == n)
                    color = vColors[i];
                else
                    color = vColors[0];
                Console.WriteLine(point);
                Console.WriteLine(prevPoint);
                gl.Color(color.R, color.G, color.B);
                gl.Vertex(prevPoint.X, gl.RenderContextProvider.Height - prevPoint.Y);
                gl.Vertex(point.X, gl.RenderContextProvider.Height - point.Y);
            }
            gl.End();
        }
    }
}
