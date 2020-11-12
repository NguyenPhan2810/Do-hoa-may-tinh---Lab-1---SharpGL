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
        
        public RectangleF BoundingBox
        {
            get
            {

                if (vPoints.Count < 1)
                    return new RectangleF();

                Point p = vPoints[0];
                float left = p.X;
                float right = p.X;
                float top = p.Y;
                float bot = p.Y;

                for(int i = 1; i < vPoints.Count; ++i)
                {
                    p = vPoints[i];
                    if (left > p.X) left = p.X;
                    if (right < p.X) right = p.X;
                    if (top > p.Y) top = p.Y;
                    if (bot < p.Y) bot = p.Y;
                }

                RectangleF result = new RectangleF(left, top, right - left, bot - top);

                return result;
            }
        }


        public Shape()
        {
            vPoints = new List<Point>();
            color = Color.Black;
            fThickness = 1f;
        }

        #region visuals
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
        #endregion

        #region properties 

        #endregion
    }
}
