using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7_Cubo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct vertex
        {
            public int x;
            public int y;
            public float r;
            public float arc;
        }
        public static vertex Center, A, B, C, D, E, F, G, H;

        private void Form1_Load(object sender, EventArgs e)
        {
            updatecenter();
        }

        Boolean centerchange = false;

       

        Color color = Color.BurlyWood;
        int side = 100, speed = 0, direction = 1; //hold;

        public static float todegrees(float radians)
        {
            return (float)(180 / Math.PI) * radians;
        }
        public static float toradians(float degrees)
        {
            return (float)Math.PI * degrees / 180;
        }
        public static int round(float x)
        {
            if (x - (int)x >= 0.5)
            {
                return (int)x + 1;
            }
            return (int)x;
        }

        void moveCube()
        {
            updatecenter();
            velocity();
            drawCube();
        }
        void drawCube()
        {
            //Graphics g = this.CreateGraphics();

            Graphics g = pictureBox1.CreateGraphics();
            Pen mypen1 = new Pen(color, 5);

            g.DrawLine(mypen1, new Point(A.x, A.y), new Point(B.x, B.y));
            g.DrawLine(mypen1, new Point(C.x, C.y), new Point(B.x, B.y));
            g.DrawLine(mypen1, new Point(C.x, C.y), new Point(D.x, D.y));
            g.DrawLine(mypen1, new Point(A.x, A.y), new Point(D.x, D.y));

            g.DrawLine(mypen1, new Point(E.x, E.y), new Point(F.x, F.y));
            g.DrawLine(mypen1, new Point(F.x, F.y), new Point(G.x, G.y));
            g.DrawLine(mypen1, new Point(G.x, G.y), new Point(H.x, H.y));
            g.DrawLine(mypen1, new Point(H.x, H.y), new Point(E.x, E.y));

            g.DrawLine(mypen1, new Point(A.x, A.y), new Point(E.x, E.y));
            g.DrawLine(mypen1, new Point(F.x, F.y), new Point(B.x, B.y));
            g.DrawLine(mypen1, new Point(C.x, C.y), new Point(G.x, G.y));
            g.DrawLine(mypen1, new Point(H.x, H.y), new Point(D.x, D.y));

        }
        void velocity()
        {
            A = carttopolar(A);
            B = carttopolar(B);
            C = carttopolar(C);
            D = carttopolar(D);
            E = carttopolar(E);
            F = carttopolar(F);
            G = carttopolar(G);
            H = carttopolar(H);

            A.arc += speed;
            B.arc += speed;
            C.arc += speed;
            D.arc += speed;
            E.arc += speed;
            F.arc += speed;
            G.arc += speed;
            H.arc += speed;

            A = polartocart(A);
            B = polartocart(B);
            C = polartocart(C);
            D = polartocart(D);
            E = polartocart(E);
            F = polartocart(F);
            G = polartocart(G);
            H = polartocart(H);
        }

        void clearPainting()
        {
            Graphics painting = pictureBox1.CreateGraphics();
            //Graphics temp = this.CreateGraphics();
            painting.Clear(Color.PapayaWhip);
        }
        public void updatecenter()
        {
            if (!centerchange)
            {
                /*Center.x = (this.Width + 100) / 2;
                Center.y = this.Height / 2;*/

                Center.x = (pictureBox1.Width) / 2;
                Center.y = pictureBox1.Height / 2;
            }

            A.x = Center.x - side / 2;
            A.y = Center.y - side / 2;
            B.x = Center.x + side / 2;
            B.y = A.y;
            C.x = B.x;
            C.y = Center.y + side / 2;
            D.x = A.x;
            D.y = C.y;

            E.x = A.x + side / 2;
            E.y = A.y - side / 2;
            F.x = B.x + side / 2;
            F.y = B.y - side / 2;
            G.x = C.x + side / 2;
            G.y = C.y - side / 2;
            H.x = D.x + side / 2;
            H.y = D.y - side / 2;

            clearPainting();

        }


        public static vertex carttopolar(vertex vertex)
        {
            int x, y;
            float temparc;

            x = vertex.x - Center.x;
            y = vertex.y - Center.y;

            vertex.r = (float)Math.Sqrt(x * x + y * y);

            if (vertex.r == 0)
            {
                vertex.arc = 0;
            }
            else if (y == 0)
            {
                if (x > 0)
                {
                    vertex.arc = 0;
                }
                else
                {
                    vertex.arc = 180;
                }
            }
            else if (x == 0)
            {
                if (y > 0)
                {
                    vertex.arc = 90;
                }
                else
                {
                    vertex.arc = 270;
                }
            }
            else
            {
                temparc = Math.Abs(todegrees((float)Math.Atan(y / x)));

                if (x > 0 && y > 0)
                {
                    vertex.arc = temparc;
                }
                else if (x < 0 && y > 0)
                {
                    vertex.arc = 180 - temparc;
                }
                else if (x < 0 && y < 0)
                {
                    vertex.arc = 180 + temparc;
                }
                else if (x > 0 && y < 0)
                {
                    vertex.arc = 360 - temparc;
                }
            }

            return vertex;
        }
        public static vertex polartocart(vertex vertex)
        {
            vertex.x = round(vertex.r * (float)Math.Cos(toradians(vertex.arc))) + Center.x;
            vertex.y = round(vertex.r * (float)Math.Sin(toradians(vertex.arc))) + Center.y;

            return vertex;
        }
        //Fin de movimientos y dibujar

        //Funciones de controles
        private void btnRIzquierda_Click(object sender, EventArgs e)
        {
            direction = -1;
            speed += 20 * direction;
            //speed += Math.Abs(hold / 50) * 1;

            moveCube();
        }
        private void BtnDisminuir_Click(object sender, EventArgs e)
        {
            side = side - 7;

            moveCube();
        }
        private void BtnRDerecha_Click(object sender, EventArgs e)
        {
            direction = 1;
            speed += 20 * direction;
            //speed += Math.Abs(hold / 50) * 1;

            moveCube();
        }
        private void BtnAumentar_Click(object sender, EventArgs e)
        {
            side = side + 7;

            moveCube();
        }
    }
}
