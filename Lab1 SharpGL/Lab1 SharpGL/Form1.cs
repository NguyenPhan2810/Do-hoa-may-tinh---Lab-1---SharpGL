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
        List<Shape> _vObjects = new List<Shape>();
        Shape _activeObject = new Shape();

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
            int len = _vObjects.Count;
            for (int i = 0; i < len; i++)
            {
                _vObjects[i].draw(gl);
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
            _activeObject = new Line();
            _vObjects.Add(_activeObject);
            _activeObject.event_MouseDown(sender, e);
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            _activeObject.event_MouseMove(sender, e);
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            _activeObject.event_MouseUp(sender, e);
        }
    }
}
