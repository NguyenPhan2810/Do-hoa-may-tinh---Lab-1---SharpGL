using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace Lab1_SharpGL
{
    class Line
    {
        Point _pStart = new Point(0, 0);

        public Point PStart
        {
            get { return _pStart; }
            set { _pStart = value; }
        }
        Point _pEnd = new Point(0, 0);

        public Point PEnd
        {
            get { return _pEnd; }
            set { _pEnd = value; }
        }

        Color _color = Color.White;
        public void Draw(OpenGL gl)
        {
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0, 0);
            gl.LineWidth(3.0f);

            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(_pStart.X, gl.RenderContextProvider.Height - _pStart.Y);
            gl.Vertex(_pEnd.X, gl.RenderContextProvider.Height - _pEnd.Y);
            gl.End();
        }
    }
}
