using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;


namespace MainForm
{
    public partial class DrawFigureControl : UserControl
    {
        // вспомогательные переменные - в них будут храниться обработанные значения, 
        // полученные при перетаскивании ползунков пользователем 
        double a = 0, b = 0, c = -5, d = 0, zoom = 1; // выбранные оси 
        int os_x = 1, os_y = 0, os_z = 0;

        // режим сеточной визуализации 
        bool Wire = false;


        public DrawFigureControl()
        {
            InitializeComponent();
        }

        private void DrawFigureControl_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut 
            Glut.glutInit();
            // инициализация режима экрана 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);


            // установка цвета очистки экрана (RGBA) 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // активация проекционной матрицы 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очистка матрицы 
            Gl.glLoadIdentity();

            // установка перспективы 
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света) 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            // установка первых элементов в списках combobox 
            comboBoxOs.SelectedIndex = 0;
            comboBoxFigure.SelectedIndex = 0;

            // активация таймера, вызывающего функцию для визуализации 
            RenderTimer.Start();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат 
            a = (double)trackBarX.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label4.Text = a.ToString();
        }

        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат 
            c = (double)trackBarZ.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label6.Text = c.ToString();
        }

        private void comboBoxOs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // в зависимости от выбранного режима 
            switch (comboBoxOs.SelectedIndex)
            {
                // устанавливаем необходимую ось (будет использована в функции glRotate**) 
                case 0:
                    {
                        os_x = 1;
                        os_y = 0;
                        os_z = 0;
                        break;
                    }
                case 1:
                    {
                        os_x = 0;
                        os_y = 1;
                        os_z = 0;
                        break;
                    }
                case 2:
                    {
                        os_x = 0;
                        os_y = 0;
                        os_z = 1;
                        break;
                    }
            }
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат 
            d = (double)trackBarAngle.Value;
            // подписываем это значение в label элементе под данным ползунком 
            label6.Text = d.ToString();
        }

        private void trackBarY_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат 
            b = (double)trackBarY.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label5.Text = b.ToString();
        }
        private void DrawFigure_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut 
            Glut.glutInit();
            // инициализация режима экрана 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);


            // установка цвета очистки экрана (RGBA) 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // активация проекционной матрицы 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очистка матрицы 
            Gl.glLoadIdentity();

            // установка перспективы 
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света) 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            // установка первых элементов в списках combobox 
            comboBoxOs.SelectedIndex = 0;
            comboBoxFigure.SelectedIndex = 0;

            // активация таймера, вызывающего функцию для визуализации 
            RenderTimer.Start();
        }


        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            // вызываем функцию отрисовки сцены 
            Draw();
        }

        // функция отрисовки 
        private void Draw()
        {
            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glClearColor(255, 255, 255, 1);
            // очищение текущей матрицы 
            Gl.glLoadIdentity();


            // помещаем состояние матрицы в стек матриц, дальнейшие трансформации затронут только визуализацию объекта 
            Gl.glPushMatrix();
            // производим перемещение в зависимости от значений, полученных при перемещении ползунков 
            Gl.glTranslated(a, b, c);
            // поворот по установленной оси 
            Gl.glRotated(d, os_x, os_y, os_z);
            // и масштабирование объекта 
            Gl.glScaled(zoom, zoom, zoom);

            DrawGrid(15, 1);//сетка


            //Gl.glBegin(Gl.GL_LINES);
            ////  рисуем координатные оси
            //Gl.glVertex2d(0, -15);
            //Gl.glVertex2d(0, 15);

            //Gl.glVertex2d(-15, 0);
            //Gl.glVertex2d(15, 0);
            //Gl.glEnd();




            // в зависимости от установленного типа объекта 
            switch (comboBoxFigure.SelectedIndex)
            {
                // рисуем нужный объект, используя функции библиотеки GLUT 
                case 0:
                    {
                        if (Wire) // если установлен сеточный режим визуализации 
                            try
                            {
                                Glut.glutWireSphere(2, 32, 32); // сеточная сфера 
                            }
                            catch { }
                        else
                            try
                            {
                                Glut.glutSolidSphere(2, 32, 32); // полигональная сфера 
                            }
                            catch { }
                        break;
                    }

                case 1:
                    {
                        if (Wire) // если установлен сеточный режим визуализации 
                        {
                            Glut.glutWireCylinder(2.0, 2.0, 4, 1); // сеточный параллелепипед
                        }

                        else
                        {

                            Glut.glutSolidCylinder(2.0, 2.0, 4, 1); // полигональный  параллелепипед
                        }
                        break;
                    }
                case 2:
                    {

                        if (Wire) // если установлен сеточный режим визуализации 
                            try
                            {
                                Glut.glutWireCone(2, 2, 4, 1); // сеточная пирамида
                            }
                            catch { }
                        else
                            try
                            {
                                Glut.glutSolidCone(2, 2, 4, 1); //  полигональная пирамида
                            }
                            catch { }
                        break;


                    }

            }

            // возвращаем состояние матрицы 
            Gl.glPopMatrix();

            // завершаем рисование 
            Gl.glFlush();

            // обновляем элемент AnT 
            AnT.Invalidate();

        }


        private void DrawGrid(int x, double quad_size)
        {

            float[] MatrixColorOX = { 1, 0, 0, 1 };
            float[] MatrixColorOY = { 0, 1, 0, 1 };
            float[] MatrixColorOZ = { 0, 0, 1, 1 };
            float[] MatrixColorOT = { 0.5f, 0.5f, 0.5f, 1.0f };

            //switch (comboBoxColor.SelectedIndex)
            //{

            //    case 0:
            //        {
            //             MatrixColorOT = { 0.5f, 0.5f, 0.5f, 1.0f };
            //            break;
            //        }

            //    case 1:
            //        {
            //             MatrixColorOT = { 20, 0.5f, 0.5f, 1.0f };
            //            break;
            //        }
            //    case 2:
            //        {
            //             MatrixColorOT = {0.5f, 30, 0.5f, 1.0f };
            //            break;
            //        }
            //}

            //x - количество или длина сетки, quad_size - размер клетки
            Gl.glPushMatrix(); //Рисуем оси координат, цвет объявлен в самом начале
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixColorOX);
            Gl.glTranslated((-x * 2) / 2, 0, 0);
            Gl.glRotated(90, 0, 1, 0);

            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixColorOZ);
            Gl.glTranslated(0, 0, (-x * 2) / 2);

            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixColorOY);
            Gl.glTranslated(0, x / 2, 0);
            Gl.glRotated(90, 1, 0, 0);
            //Gl.glBegin(Gl.GL_LINES);
            //Gl.glVertex3d(0, 0, 22);
            //Gl.glVertex3d(0, 0, -8);
            //Gl.glEnd();
            Gl.glPopMatrix();
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE, MatrixColorOT);
            Gl.glBegin(Gl.GL_LINES);



            // Рисуем сетку 2х2 вдоль осей
            for (double i = -x; i <= x; i += 2)
            {
                Gl.glBegin(Gl.GL_LINES);
                // Ось Х
                Gl.glVertex3d(-x * quad_size, 0, i * quad_size);
                Gl.glVertex3d(x * quad_size, 0, i * quad_size);

                // Ось Z
                Gl.glVertex3d(i * quad_size, 0, -x * quad_size);
                Gl.glVertex3d(i * quad_size, 0, x * quad_size);
                Gl.glEnd();
            }

        }
    }
}
