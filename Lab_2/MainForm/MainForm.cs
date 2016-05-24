using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassFigure;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;


namespace MainForm
{
    public partial class MainForm : Form
    {
        private DataTable _datatable;

        /// <summary>
        /// Метод закраски строк таблицы
        /// </summary>
        public void Shading()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals("Шар"))
                {
                    dataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                }

                else if (row.Cells[0].Value.ToString().Equals("Паралелепипед"))
                {
                    dataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Cyan;
                }

                else if (row.Cells[0].Value.ToString().Equals("Пирамида"))
                {
                    dataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Cornsilk;
                }
            }
        }


        public MainForm(string[] args)
        {

            if (args.Length == 0)
            {
                InitializeComponent();
                AnT.InitializeContexts();
                CreateDatatable();
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


            }

            else
            {
                InitializeComponent();
                CreateDatatable();
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                var serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
                serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

                string fullPath;

                string path1 = args[0];

                fullPath = Path.GetFullPath(path1);
                FileStream file = new FileStream(fullPath, FileMode.Open);

                using (StreamReader streamReader = new StreamReader(file))
                {

                    using (Newtonsoft.Json.JsonReader jReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {

                        ListFigures.List = serializer.Deserialize<List<IFigure>>(jReader);

                        for (int i = 0; i < ListFigures.List.Count; i++)
                        {
                            var figure = ListFigures.List[i];
                            var row = _datatable.NewRow();
                            row[0] = figure.Name;
                            row[1] = figure.CalculateVolume();
                            _datatable.Rows.Add(row);
                        }
                    }
                    MessageBox.Show("Файл загружен");
                }
            }
        }


        public class ListFigures
        {
            public static List<IFigure> List = new List<IFigure>();
        }

        /// <summary>
        /// Создание таблицы
        /// </summary>
        private void CreateDatatable()
        {

            _datatable = new DataTable();

            var column0 = new DataColumn("Фигура")
            {
                Caption = "Figure",
                DataType = typeof(string),
                ReadOnly = true
            };
            var column2 = new DataColumn("Обьём")
            {
                Caption = "Volume",
                DataType = typeof(double),
                ReadOnly = true
            };

            _datatable.Columns.Add(column0);
            _datatable.Columns.Add(column2);

            dataGridView.DataSource = _datatable;
        }


        // вспомогательные переменные - в них будут храниться обработанные значения, 
        // полученные при перетаскивании ползунков пользователем 
        double a = 0, b = 0, c = -5, d = 0, zoom = 1; // выбранные оси 
        int os_x = 1, os_y = 0, os_z = 0;

        // режим сеточной визуализации 
        bool Wire = false;

        private void MainForm_Load(object sender, EventArgs e)
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
            Glu.gluPerspective(100, (float)AnT.Width / (float)AnT.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света) 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            // установка первых элементов в списках combobox 
            comboBoxOs.SelectedIndex = 0;
            comboBoxFigure.SelectedIndex = 0;

            // устанавливка выбора цвета фона по умалчанию
            comboBoxColor.SelectedIndex = 0;

            // активация таймера
            RenderTimer.Start();

        }


        /// <summary>
        /// Обработчик кнопки "Добавить фигуру" 
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewFigures f = new NewFigures();
            IFigure figure = Figure;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                figure = f.Figure;
                ListFigures.List.Add(figure);
                var row = _datatable.NewRow();
                row[0] = figure.Name;
                row[1] = figure.CalculateVolume();
                _datatable.Rows.Add(row);
                dataGridView.Update();
            }

            Shading();
        }


        /// <summary>
        /// Открытое свойсво Figure 
        /// </summary>
        public IFigure Figure { get; set; }

        private int _figure;
        /// <summary>
        /// Обработчик кнопки "Заполнить таблицу" 
        /// </summary>
        private void buttonRandomData_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int style = rnd.Next(0, 3);
                IFigure figureModel = null;
                switch (_figure)
                {
                    case 0:
                        figureModel = new Spher(Convert.ToInt32(rnd.Next(0, 10)));
                        break;
                    case 1:
                        figureModel = new Parallelepiped(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(1, 15));
                        break;
                    case 2:
                        figureModel = new Piramide(rnd.Next(0, 100), rnd.Next(0, 100));
                        break;

                }
                Figure = figureModel;
                DialogResult = DialogResult.OK;
                _figure = (rnd.Next(0, 3));
                IFigure figure = null;
                figure = Figure;
                ListFigures.List.Add(figure);
                var row = _datatable.NewRow();
                row[0] = figure.Name;
                row[1] = figure.CalculateVolume();
                _datatable.Rows.Add(row);
            }

            Shading();
        }

        /// <summary>
        /// Обработчик кнопки "Удалить строку" 
        /// </summary>
        private void buttonRemoveData_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Удалить обьект?", "Удалить", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                    {
                        ListFigures.List.RemoveAt(cell.RowIndex);
                        dataGridView.Rows.RemoveAt(cell.RowIndex);
                        dataGridView.Update();

                    }
                }

            }
            catch
            {

            }
        }

        /// <summary>
        /// Обработчик кнопки "Новый файл" 
        /// </summary>
        private void newFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Все не сохраннёные данные могут быть потеряны. Создать новый файл?",
                "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    _datatable.Rows.Clear();
                    ListFigures.List.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            // вызываем функцию отрисовки сцены 
            Draw();
        }

        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый  формат 
            a = (double)trackBarX.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label3.Text = a.ToString();
        }

        private void trackBarY_Scroll_1(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый  формат 
            b = (double)trackBarY.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label4.Text = b.ToString();
        }


        private void trackBarZ_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый  формат 
            c = (double)trackBarZ.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком 
            label5.Text = c.ToString();
        }

        private void trackBarAngle_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый  формат 
            d = (double)trackBarAngle.Value;
            // подписываем это значение в label элементе под данным ползунком 
            label6.Text = d.ToString();
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // если отмечен CheckBox
            if (checkBox.Checked)
            {
                // устанавливаем сеточный режим визуализации 
                Wire = true;
            }
            else
            {
                // иначе - полигональная визуализация 
                Wire = false;
            }
        }

        /// <summary>
        /// Выбираем ось
        /// </summary>
        private void comboBoxOs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // в зависимости от выбранного режима 
            switch (comboBoxOs.SelectedIndex)
            {
                // устанавливаем необходимую ось (использована в функции glRotate) 
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

        /// <summary>
        /// Метод отрисовки сетки
        /// </summary>
        private void DrawGrid(int x, double quad_size)
        {
            //цвет сетки
            float[] MatrixColorOT = { 0.5f, 0.5f, 0.5f, 1.0f };

            //x - количество или длина сетки, quad_size - размер клетки
            Gl.glPushMatrix(); //Оси координат
            Gl.glTranslated((-x * 2) / 2, 0, 0);
            Gl.glRotated(90, 0, 1, 0);
    
            Gl.glPopMatrix();
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, (-x * 2) / 2);
     
            Gl.glPopMatrix();
            Gl.glPushMatrix();
            Gl.glTranslated(0, x / 2, 0);
            Gl.glRotated(90, 1, 0, 0);

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


        /// <summary>
        /// Метод отрисовки фигуры
        /// </summary>
        public void TypeFigureDraw()
        {
             // в зависимости от установленного типа объекта 
            switch (comboBoxFigure.SelectedIndex)
            {
                // рисуем нужный объект, используя функции библиотеки GLUT 
                case 0:
                    {
                    if (Wire) // если установлен сеточный режим визуализации 
                        try
                        {
                                Glut.glutWireSphere(objectViewer1.Radius, 32, 32); // сеточная сфера 
                        }
                        catch { }
                    else
                        try
                        {
                                Glut.glutSolidSphere(objectViewer1.Radius, 32, 32); // полигональная сфера 
                        }
                        catch { }
                    break;
                }

                case 1:
                    {
                    if (Wire) // если установлен сеточный режим визуализации 
                    {
                        try
                        {
                            Gl.glBegin(Gl.GL_LINE_STRIP); // рисуем сеточный параллелепипед

                            Gl.glVertex3d(0, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, objectViewer1.B);
                            Gl.glVertex3d(0, 0, objectViewer1.B);
                            Gl.glVertex3d(0, 0, 0);

                            Gl.glVertex3d(0, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, objectViewer1.B);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, objectViewer1.B);

                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, 0, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, 0);
                            Gl.glEnd();
                        }
                        catch { }
                    }

                    else
                    {
                        try
                        {
                            Gl.glBegin(Gl.GL_POLYGON); // рисуем полигональный  параллелепипед

                            Gl.glVertex3d(0, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, objectViewer1.B);
                            Gl.glVertex3d(0, 0, objectViewer1.B);
                            Gl.glVertex3d(0, 0, 0);

                            Gl.glVertex3d(0, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, 0);
                            Gl.glVertex3d(objectViewer1.A, 0, objectViewer1.B);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, objectViewer1.B);

                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, 0);
                            Gl.glVertex3d(objectViewer1.A, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, 0, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, objectViewer1.B);
                            Gl.glVertex3d(0, objectViewer1.C, 0);

                            Gl.glEnd();
                        }
                        catch { }
                    }
                    break;
                }
                case 2:
                    {

                    if (Wire) // если установлен сеточный режим визуализации 
                        try
                        {
                            Glut.glutWireCone(objectViewer1.S, objectViewer1.H, 4, 32); // сеточная пирамида
                        }
                        catch { }
                    else
                        try
                        {
                            Glut.glutSolidCone(objectViewer1.S, objectViewer1.H, 4, 32); //  полигональная пирамида
                        }
                        catch { }
                    break;
                }

            }

        }

        /// <summary>
        /// Метод отрисовки сцены
        /// </summary>
        private void Draw()
        {
            if (comboBoxColor.SelectedIndex == 0)
            {
                // цвет очистки окна
                Gl.glClearColor(255, 255, 255, 1);
            }
            else if (comboBoxColor.SelectedIndex == 1)
            {
                Gl.glClearColor(0, 0, 0, 1);
            }

            // очищение текущей матрицы 
            Gl.glLoadIdentity();

            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            // помещаем  матрицы в стек матриц
            Gl.glPushMatrix();
            // производим перемещение в зависимости от значений, полученных при перемещении ползунков 
            Gl.glTranslated(a, b, c);


            // поворот по установленной оси 

            Gl.glRotated(d, os_x, os_y, os_z);

            DrawGrid(50, 1);//сетка

            TypeFigureDraw();//фигура

            // возвращаем состояние матрицы 
            Gl.glPopMatrix();

            // завершаем рисование 
            Gl.glFlush();

            // обновляем элемент AnT 
            AnT.Invalidate();

        }

        /// <summary>
        /// Десериализация 
        /// </summary>
        private void openFile_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = openFileDialog.FileName;

            using (StreamReader streamReader = new StreamReader(fileName))
            {

                using (Newtonsoft.Json.JsonReader jReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    ListFigures.List = serializer.Deserialize<List<IFigure>>(jReader);

                    for (int i = 0; i < ListFigures.List.Count; i++)
                    {
                        var figure = ListFigures.List[i];
                        var row = _datatable.NewRow();
                        row[0] = figure.Name;
                        row[1] = figure.CalculateVolume();
                        _datatable.Rows.Add(row);
                    }

                }
                MessageBox.Show("Файл загружен");
            }
        }

        /// <summary>
        /// Сериализация 
        /// </summary>
        private void saveFile_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MyFigure | *.figure";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = saveFileDialog.FileName;

            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                using (Newtonsoft.Json.JsonWriter jWriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jWriter, ListFigures.List);
                }
                MessageBox.Show("Сохранено");
            }
        }


        /// <summary>
        /// Обработчик кнопки "Закрыть"
        /// </summary>
        private void closeFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть программу?", "Завершение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Application.Exit();
        }

        /// <summary>
        /// Обработчик кнопки "Изменить данные" 
        /// </summary>
        private void changeFigure_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Изменить обьект?", "Изменение обьекта", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null)
                {
                    foreach (DataGridViewCell cell in dataGridView.SelectedCells)
                    {
                        NewFigures f = new NewFigures();

                        var a = dataGridView.CurrentRow.Index;
                        IFigure figure = ListFigures.List[a];
                        f.ShowDialog();



                        if (f.DialogResult == DialogResult.OK)
                        {

                            dataGridView.Rows.RemoveAt(cell.RowIndex);
                            figure = f.Figure;
                            ListFigures.List.Insert(dataGridView.CurrentRow.Index, figure);
                            var row = _datatable.NewRow();
                            row[0] = figure.Name;
                            row[1] = figure.CalculateVolume();
                            _datatable.Rows.InsertAt(row, dataGridView.CurrentRow.Index);
                            dataGridView.Update();
                        }
                    }
                }

                Shading();
            }
        }

        /// <summary>
        /// Обработчик события по закрытию формы 
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
             MessageBox.Show("Закрыть программу?", "Все не сохранённые данные могут быть потеряны!",
                 MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        /// <summary>
        /// Обработчик события по нажатию строки в dataGridView 
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                objectViewer1.figure = ListFigures.List[e.RowIndex];


                if (dataGridView.SelectedCells[0].Value.ToString().Equals("Шар"))
                {
                    comboBoxFigure.SelectedIndex = 0;
                }

                else if (dataGridView.SelectedCells[0].Value.ToString().Equals("Паралелепипед"))
                {
                    comboBoxFigure.SelectedIndex = 1;
                }

                else if (dataGridView.SelectedCells[0].Value.ToString().Equals("Пирамида"))
                {
                    comboBoxFigure.SelectedIndex = 2;
                }

                Shading();
            }
            catch
            {

            }
        }

    }
}
