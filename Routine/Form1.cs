using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Routine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.simpleOpenGlControl1.InitializeContexts();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            lblTime.Text = NowTime.ToString();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glOrtho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0);

            drawWall();
            // drawTable();
            
        }

        private void drawWall()
        {
            Gl.glColor3ub(200, 200, 200);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(-1.0, 1.0, 0);
            Gl.glVertex3d(0.55, 1.0, 0);
            Gl.glVertex3d(0.55, -0.2, 0);
            Gl.glVertex3d(-1.0, -0.2, 0);
            Gl.glEnd();

            Gl.glColor3ub(175, 175, 175);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(0.55, 1.0, 0);
            Gl.glVertex3d(1.0, 1.0, 0);
            Gl.glVertex3d(1.0, -0.8, 0);
            Gl.glVertex3d(0.55, -0.2, 0);
            Gl.glEnd();

            Gl.glColor3ub(225, 225, 225);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(-1.0, -0.2, 0);
            Gl.glVertex3d(0.55, -0.2, 0);
            Gl.glVertex3d(1.0, -0.8, 0);
            Gl.glVertex3d(1.0, -1.0, 0);
            Gl.glVertex3d(-1.0, -1.0, 0);
            Gl.glEnd();
        }
        /*
        private void drawTable()
        {
            Gl.glColor3ub(225, 150, 50);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(0.55, 0.3, 0.01);
            Gl.glVertex3d(0.9, 0.0, 0);
            Gl.glVertex3d(-0.7, 0.0, 0);
            Gl.glVertex3d(-0.35, 0.3, 0);
            Gl.glEnd();

            Gl.glColor3ub(200, 125, 25);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(-0.7, 0.0, 0.01);
            Gl.glVertex3d(0.9, 0.0, 0);
            Gl.glVertex3d(0.9, -0.03, 0);
            Gl.glVertex3d(-0.7, -0.03, 0);
            Gl.glEnd();

            Gl.glColor3ub(180, 105, 5);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(0.9, -0.03, 0.01);
            Gl.glVertex3d(0.9, -0.67, 0.01);
            Gl.glVertex3d(0.86, -0.67, 0.01);
            Gl.glVertex3d(0.86, -0.03, 0.01);
            Gl.glEnd();
        }*/
    }
}
