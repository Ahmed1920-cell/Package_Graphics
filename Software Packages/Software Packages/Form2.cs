using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Packages
{
    public partial class Overorigin : Form
    {
        public Point origin = new Point(391, 339);
        public Overorigin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X1, X2,X3,X4, Y1, Y2, Y3, Y4 ;
             X1 = Convert.ToInt32(X1Draw.Text);
             Y1 = Convert.ToInt32(Y1Draw.Text);

             X2 = Convert.ToInt32(X2Draw.Text);
             Y2 = Convert.ToInt32(Y2Draw.Text);

             X3 = Convert.ToInt32(X3Draw.Text);
             Y3 = Convert.ToInt32(Y3Draw.Text);

             X4 = Convert.ToInt32(X4Draw.Text);
             Y4 = Convert.ToInt32(Y4Draw.Text);
            panel1.Refresh();
            lineDDA(X1, Y1, X2, Y2, Brushes.Blue);
            lineDDA(X2, Y2, X3, Y3, Brushes.Blue);
            lineDDA(X3, Y3, X4, Y4, Brushes.Blue);
            lineDDA(X1, Y1, X4, Y4, Brushes.Blue);

        }
        
        private void lineDDA(int x0, int y0, int xEnd, int yEnd,Brush aBrush)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yIncrement = Convert.ToDouble(dy) / Convert.ToDouble(steps);
            
            var g = panel1.CreateGraphics();
            setPixel(Math.Round(x), Math.Round(y), aBrush, g);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                setPixel(Math.Round(x), Math.Round(y), aBrush, g);
            }
        }
        
        private void setPixel(double x, double y, Brush aBrush, Graphics g)
        {
            g.FillRectangle(aBrush, Convert.ToInt32(x) + origin.X, origin.Y - Convert.ToInt32(y), 2, 2);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void Translation2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            int X_Translation = Convert.ToInt32(X.Text);
            int Y_Translation = Convert.ToInt32(Y.Text);

            Translation(ref X1, ref Y1, X_Translation, Y_Translation);
            Translation(ref X2, ref Y2, X_Translation, Y_Translation);
            Translation(ref X3, ref Y3, X_Translation, Y_Translation);
            Translation(ref X4, ref Y4, X_Translation, Y_Translation);
            lineDDA(X1, Y1, X2, Y2, Brushes.Green);
            lineDDA(X2, Y2, X3, Y3, Brushes.Green);
            lineDDA(X3, Y3, X4, Y4, Brushes.Green);
            lineDDA(X1, Y1, X4, Y4, Brushes.Green);
        }
        public void Translation(ref int X, ref int Y, int X_Translation, int Y_Translation)
        {
            X += X_Translation;
            Y += Y_Translation;
        }
        public void Scaling(ref int X, ref int Y, int X_Scaling, int Y_Scaling)
        {
            X = X * X_Scaling;
            Y = Y * Y_Scaling;
        }
        public void Rotation(ref int X, ref int Y, double Angel)
        {

            double x, y, con, sin;
            con = Cos(Angel);
            sin = Math.Sin(Math.PI * Convert.ToDouble(Angel / 180));

            x = (X * con) + (Y * sin);
            y = (X * sin) - (Y * con);

            X = Convert.ToInt32(Math.Round(x));
            Y = Convert.ToInt32(Math.Round(y));

        }
        public double Cos(double Angel)
        {
            double angel = Convert.ToInt32(Math.Cos(Math.PI * Angel / 180) * 100);
            angel = Convert.ToDouble(angel / 100);
            return angel;
        }
        private void Scaling2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            int X_Scaling = Convert.ToInt32(X.Text);
            int Y_Scaling = Convert.ToInt32(Y.Text);

            Scaling(ref X1, ref Y1, X_Scaling, Y_Scaling);
            Scaling(ref X2, ref Y2, X_Scaling, Y_Scaling);
            Scaling(ref X3, ref Y3, X_Scaling, Y_Scaling);
            Scaling(ref X4, ref Y4, X_Scaling, Y_Scaling);
            lineDDA(X1, Y1, X2, Y2, Brushes.Red);
            lineDDA(X2, Y2, X3, Y3, Brushes.Red);
            lineDDA(X3, Y3, X4, Y4, Brushes.Red);
            lineDDA(X1, Y1, X4, Y4, Brushes.Red);
        }
        public void Shearing_X(ref int X, ref int Y, int Y_Shearing)
        {
            int x, y;
            x = X + Y_Shearing * Y;
            y = Y;
            X = x;
            Y = y;
        }
        public void Shearing_Y(ref int X, ref int Y, int X_Shearing)
        {
            int x, y;
            x = X * 1;
            y = X * X_Shearing + Y;
            X = x;
            Y = y;
        }
        private void Rotation2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int Angel = Convert.ToInt32(angel.Text);

            Rotation(ref X1, ref Y1, Angel);      
            Rotation(ref X2, ref Y2, Angel);          
            Rotation(ref X3, ref Y3, Angel);           
            Rotation(ref X4, ref Y4, Angel);

            lineDDA(X1, Y1, X2, Y2,Brushes.Purple);
            lineDDA(X2, Y2, X3, Y3,Brushes.Purple);
            lineDDA(X3, Y3, X4, Y4,Brushes.Purple);
            lineDDA(X1, Y1, X4, Y4,Brushes.Purple);
        }

        private void ShearX_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int X_Shearing = Convert.ToInt32(ShX.Text);

            Shearing_X(ref X1, ref Y1, X_Shearing);
            Shearing_X(ref X2, ref Y2, X_Shearing);
            Shearing_X(ref X3, ref Y3, X_Shearing);
            Shearing_X(ref X4, ref Y4, X_Shearing);

            lineDDA(X1, Y1, X2, Y2, Brushes.Yellow);
            lineDDA(X2, Y2, X3, Y3, Brushes.Yellow);
            lineDDA(X3, Y3, X4, Y4, Brushes.Yellow);
            lineDDA(X1, Y1, X4, Y4, Brushes.Yellow);
        }

        private void ShearY_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int Y_Shearing = Convert.ToInt32(ShY.Text);

            Shearing_Y(ref X1, ref Y1, Y_Shearing);
            Shearing_Y(ref X2, ref Y2, Y_Shearing);
            Shearing_Y(ref X3, ref Y3, Y_Shearing);
            Shearing_Y(ref X4, ref Y4, Y_Shearing);

            lineDDA(X1, Y1, X2, Y2, Brushes.DarkOrange);
            lineDDA(X2, Y2, X3, Y3, Brushes.DarkOrange);
            lineDDA(X3, Y3, X4, Y4, Brushes.DarkOrange);
            lineDDA(X1, Y1, X4, Y4, Brushes.DarkOrange);
        }

        private void OverX_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            lineDDA(-X1, Y1, -X2, Y2, Brushes.DarkOliveGreen);
            lineDDA(-X2, Y2, -X3, Y3, Brushes.DarkOliveGreen);
            lineDDA(-X3, Y3, -X4, Y4, Brushes.DarkOliveGreen);
            lineDDA(-X1, Y1, -X4, Y4, Brushes.DarkOliveGreen);
        }

        private void OverY_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            lineDDA(X1, -Y1, X2, -Y2, Brushes.Brown);
            lineDDA(X2, -Y2, X3, -Y3, Brushes.Brown);
            lineDDA(X3, -Y3, X4, -Y4, Brushes.Brown);
            lineDDA(X1, -Y1, X4, -Y4, Brushes.Brown);
        }

        private void Overorigin1_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            lineDDA(-X1, -Y1, -X2, -Y2, Brushes.DarkCyan);
            lineDDA(-X2, -Y2, -X3, -Y3, Brushes.DarkCyan);
            lineDDA(-X3, -Y3, -X4, -Y4, Brushes.DarkCyan);
            lineDDA(-X1, -Y1, -X4, -Y4, Brushes.DarkCyan);
        }


    }
}
