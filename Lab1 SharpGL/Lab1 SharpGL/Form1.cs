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
        int _activeObjectIndex = -1;
        string _newShape = "";
        float _shapeThickness = 1f;
        Color _shapeColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private Shape getNewShape()
        {
            Shape newShape;
            if (_newShape == "Line") newShape = new Line();
            else if (_newShape == "Rectangle") newShape = new Rectangle();
            else if (_newShape == "Triangle") newShape = new Triangle();
            else if (_newShape == "Pentagon") newShape = new Pentagon();
            else if (_newShape == "Hexagon") newShape = new Hexagon();
            else if (_newShape == "Circle") newShape = new Circle();
            else if (_newShape == "Ellipse") newShape = new Ellipse();
            else newShape = new Shape();

            newShape.color = _shapeColor;
            newShape.fThickness = _shapeThickness;

            return newShape;
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.ClearColor(1, 1, 1, 1);

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

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            _vObjects.Add(getNewShape());
            _activeObjectIndex = _vObjects.Count - 1;
            if (_activeObjectIndex >= 0)
                _vObjects[_activeObjectIndex].event_MouseDown(sender, e);
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_activeObjectIndex >= 0)
                _vObjects[_activeObjectIndex].event_MouseMove(sender, e);
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (_activeObjectIndex >= 0)
                _vObjects[_activeObjectIndex].event_MouseUp(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox1 = (ComboBox)sender;
            string selectedItem = comboBox1.SelectedItem.ToString();
            _newShape = selectedItem;            
        }

        private void ThicknessSelector_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown selector = (NumericUpDown)sender;
            _shapeThickness = (float)selector.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = MyDialog.Color;
                _shapeColor = MyDialog.Color;
            }
        }
    }
}
