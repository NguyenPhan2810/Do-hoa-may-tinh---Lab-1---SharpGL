using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace Lab1_SharpGL
{
    public partial class Form1 : Form
    {
        List<Line> _objs = new List<Line>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.ClearColor(0, 0, 0, 0);

            gl.MatrixMode(OpenGL.GL_PROJECTION);

            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();

            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            int len = _objs.Count;
            for (int i = 0; i < len; i++)
            {
                _objs[i].Draw(gl);
            }
            gl.Flush();
        }


        private void openGLControl_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Line l = new Line();
                l.PStart = l.PEnd = e.Location;
                _objs.Add(l);
            }
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int len = _objs.Count;
                if (len > 0)
                    _objs[len - 1].PEnd = e.Location;
            }
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            int len = _objs.Count;
            if (len > 0)
                _objs[len - 1].PEnd = e.Location;
        }
    }
}
