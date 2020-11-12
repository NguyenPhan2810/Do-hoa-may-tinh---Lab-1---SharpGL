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
        public Color        color;
        public float        fThickness;

        public Shape()
        {
            vPoints = new List<Point>();
            color = Color.Black;
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

            int n = vPoints.Count;

            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(color.R, color.G, color.B);
            for (int i = 0; i < n; ++i)
            {
                Point point = vPoints[i];
                gl.Vertex(point.X, gl.RenderContextProvider.Height - point.Y);
            }
            gl.End();
        }
    }
}
