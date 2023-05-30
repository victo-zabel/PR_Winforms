using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvadrattreygolnikelllips
{
    public partial class Form1 : Form
    {
        // создание классов фигур
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        //переменные для проверки
        bool a = false; // rectangle
        bool b = false; // circle
        bool c = false; // square

        // координаты
        int RX = 0; //rectangle
        int RY = 0;
        int CX = 0; //circle
        int CY = 0;
        int SX = 0; //square
        int SY = 0;

        int X, Y, dX, dY; //еще координаты для "формы" чтоб ее
        int LastCl = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // фигуры
            e.Graphics.FillEllipse(Brushes.Red, Circle);
            e.Graphics.FillRectangle(Brushes.Blue, Square);
            e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);

            if (a)
            {
                LastCl = 1;
               
            }
            else if (b)
            {
                LastCl = 2;
               
            }
            else if (c)
            {
                LastCl = 3;
               
            }

            if(LastCl == 1)
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                
            }
            else if(LastCl == 2)
            {
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
               
            }
            else if(LastCl == 3)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                
            }
            pictureBox1.Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // фиксирование координат и проверка какой элемент выбран
            if ((e.X < Rectangle.X + Rectangle.Width) && (e.X > Rectangle.X)) // прямоугольник 
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    a = true;

                    RX = e.X - Rectangle.X;
                    RY = e.Y - Rectangle.Y;
                }
            }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X)) // эллипс
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    b = true;

                    CX = e.X - Circle.X;
                    CY = e.Y - Circle.Y;
                }
            }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X)) // квадрат
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    c = true;

                    SX = e.X - Square.X;
                    SY = e.Y - Square.Y;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           // проверяется какой объект взят и задается ластовый клик  
            if(a) 
            {
                LastCl = 1;
                a = false;
            }
            else if(b)
            {
                LastCl = 2;
                b = false;
            }
            else if(c)
            {
                LastCl = 3;
                c = false;
            }

           
                if (LastCl == 2)
                {
                    if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X)) //форма круга на квадрат
                    {
                        if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                        {
                            X = Circle.X;
                            Y = Circle.Y;
                            dX = CX;
                            dY = CY;
                            Circle.X = Square.X;
                            Circle.Y = Square.Y;
                            CX = SX;
                            CY = SY;
                            Square.X = X;
                            Square.Y = Y;
                            SX = dX;
                            SY = dY;
                        }
                    }
                }
            if (LastCl == 3)
            {
                if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X)) //квадат на круг
                {
                    if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = SX;
                        dY = SY;
                        Square.X = Circle.X;
                        Square.Y = Circle.Y;
                        SX = CX;
                        SY = CY;
                        Circle.X = X;
                        Circle.Y = Y;
                        CX = dX;
                        CY = dY;
                    }
                }
            }
            if(LastCl == 1)
            {
                if((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X)) //прямоуольник на квадрат
                {
                    if((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                    {
                        X = Rectangle.X;
                        Y = Rectangle.Y;
                        dX = RX;
                        dY = RY;
                        Rectangle.X = Square.X;
                        Rectangle.Y = Square.Y;
                        RX = SX;
                        RY = SY;
                        Square.X = X;
                        Square.Y = Y;
                        SX = dX;
                        SY = dY;
                    }
                }
            }
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // какой объект взят и переносится, сверение
            if(b) // круг
            {
                Circle.X = e.X - CX;
                Circle.Y = e.Y - CY;
            }
            if(a) // прямоугольник
            {
                Rectangle.X = e.X - RX;
                Rectangle.Y = e.Y - RY;
            }
            if(c) // квадрат
            {
                Square.X = e.X - SX;
                Square.Y = e.Y - SY;
            }
            pictureBox1.Invalidate(); // перерисовка


            // высвечивается в "информации" при переносе на "вид"
            if((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X)) //SQUARE
            {
                if((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                {
                    label3.Text = "Square";
                }
            }
            if((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Rectangle";
                }
            }
            if((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Circle";
                }
            }
        }
    }
}
