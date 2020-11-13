namespace Lab1_SharpGL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl = new SharpGL.OpenGLControl();
            this.ShapeSelector = new System.Windows.Forms.ComboBox();
            this.ThicknessSelector = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openGLControl.BackColor = System.Drawing.Color.White;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.FrameRate = 120;
            this.openGLControl.Location = new System.Drawing.Point(113, 57);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(947, 666);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // ShapeSelector
            // 
            this.ShapeSelector.FormattingEnabled = true;
            this.ShapeSelector.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Triangle",
            "Pentagon",
            "Hexagon",
            "Circle",
            "Ellipse"});
            this.ShapeSelector.Location = new System.Drawing.Point(13, 13);
            this.ShapeSelector.Name = "ShapeSelector";
            this.ShapeSelector.Size = new System.Drawing.Size(93, 21);
            this.ShapeSelector.TabIndex = 1;
            this.ShapeSelector.Text = "Shape";
            this.ShapeSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ThicknessSelector
            // 
            this.ThicknessSelector.DecimalPlaces = 1;
            this.ThicknessSelector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ThicknessSelector.Location = new System.Drawing.Point(113, 13);
            this.ThicknessSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThicknessSelector.Name = "ThicknessSelector";
            this.ThicknessSelector.Size = new System.Drawing.Size(40, 20);
            this.ThicknessSelector.TabIndex = 2;
            this.ThicknessSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThicknessSelector.ValueChanged += new System.EventHandler(this.ThicknessSelector_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(160, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1072, 735);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThicknessSelector);
            this.Controls.Add(this.ShapeSelector);
            this.Controls.Add(this.openGLControl);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Simple drawings";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ComboBox ShapeSelector;
        private System.Windows.Forms.NumericUpDown ThicknessSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

